using System.Diagnostics;

namespace InkPos
{
    internal class Program
    {
        private static string PostgresPath => Path.Combine(Application.StartupPath, "pgsql", "bin", "pg_ctl.exe");
        private static string DataDir => Path.Combine(Application.StartupPath, "pgsql", "data");
        private static string LogFile => Path.Combine(Application.StartupPath, "pgsql", "log.txt");

        [STAThread]
        static void Main()
        {
            InitializeDatabase();
            StartPostgres();

            ApplicationConfiguration.Initialize();
            Application.ApplicationExit += OnApplicationExit;
            Application.Run(new agregar_producto());
        }

        static void InitializeDatabase()
        {
            if (!Directory.Exists(DataDir) || Directory.GetFiles(DataDir).Length == 0)
            {
                string initdbPath = Path.Combine(Application.StartupPath, "pgsql", "bin", "initdb.exe");
                string psqlPath = Path.Combine(Application.StartupPath, "pgsql", "bin", "psql.exe");
                string sqlScriptPath = Path.Combine(Application.StartupPath, "pgsql", "share", "InkPosDB.sql");

                // 1. Inicializar la base de datos
                var initProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = initdbPath,
                        Arguments = $"-D \"{DataDir}\" -U postgres --encoding=UTF8 --locale=en_US",
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                    }
                };
                initProcess.Start();
                initProcess.WaitForExit();

                // 2. Iniciar temporalmente el servidor en puerto 5433
                var startProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = PostgresPath,
                        Arguments = $"start -D \"{DataDir}\" -o \"-p 5433\" -w", // -w = espera a que arranque
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };
                startProcess.Start();
                startProcess.WaitForExit();

                // 3. Ejecutar el archivo SQL
                var psqlProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = psqlPath,
                        Arguments = $"-U postgres -p 5433 -f \"{sqlScriptPath}\"",
                        UseShellExecute = false,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true,
                        EnvironmentVariables =
                {
                    ["PGPASSWORD"] = "" // si fuera necesario
                }
                    }
                };
                psqlProcess.Start();
                string output = psqlProcess.StandardOutput.ReadToEnd();
                string errors = psqlProcess.StandardError.ReadToEnd();
                psqlProcess.WaitForExit();

                // (Opcional: escribir log del resultado)
                File.WriteAllText(Path.Combine(Application.StartupPath, "pgsql", "psql_output.txt"), output + "\n" + errors);

                // 4. Detener el servidor temporal
                var stopProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = PostgresPath,
                        Arguments = $"stop -D \"{DataDir}\" -m fast -w", // -w = espera a que se detenga
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };
                stopProcess.Start();
                stopProcess.WaitForExit();
            }
        }

        static void StartPostgres()
        {
            var startProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = PostgresPath,
                    Arguments = $"start -D \"{DataDir}\" -l \"{LogFile}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                }
            };
            startProcess.Start();
            startProcess.WaitForExit(); // Espera que el comando pg_ctl termine (el servidor sigue corriendo)
        }

        static void OnApplicationExit(object? sender, System.EventArgs e)
        {
            var stopProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = PostgresPath,
                    Arguments = $"stop -D \"{DataDir}\" -m fast",
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            stopProcess.Start();
            stopProcess.WaitForExit();
        }
    }
}