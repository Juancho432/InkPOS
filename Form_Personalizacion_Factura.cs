
using System.Text.Json;
using System.Windows.Forms;

namespace InkPos
{
    public partial class Form_Personalizacion_Factura : Form
    {
        private readonly Empleado EmpleadoActual;
        private readonly DataBaseHandler Database;
        private string? LogoFile = null;

        public Form_Personalizacion_Factura(Empleado empleado, DataBaseHandler database)
        {
            EmpleadoActual = empleado;
            Database = database;
            InitializeComponent();

        }

        private void Form_Personalizacion_Factura_Load(object sender, EventArgs e)
        {
            lbl_upload.Visible = false;
            button_upload.Visible = false;
        }

        private void CB_valor_a_modificar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_valor_a_modificar.SelectedItem != null && CB_valor_a_modificar.SelectedItem.ToString() == "Logo")
            {
                // Mostrar controles para subir logo
                lbl_upload.Visible = true;
                button_upload.Visible = true;

                // Ocultar controles de texto
                lbl_ingresevalor.Visible = false;
                txtbox_nuevo_valor.Visible = false;
            }
            else
            {
                // Ocultar controles de subir logo
                lbl_upload.Visible = false;
                button_upload.Visible = false;

                // Mostrar controles de texto
                lbl_ingresevalor.Visible = true;
                txtbox_nuevo_valor.Visible = true;
            }
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Title = "Seleccione de Logo";
            saveFileDialog.Filter = "Archivos de imagen (*.png)|*.png";
            saveFileDialog.FileName = "Logo.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                LogoFile = saveFileDialog.FileName;
            }
        }

        private void Button_confirmar_Click(object sender, EventArgs e)
        {
            int campo = CB_valor_a_modificar.SelectedIndex;
            string nuevoValor = txtbox_nuevo_valor.Text.Trim();
            string rutaJson = Path.Combine(AppContext.BaseDirectory, "config.json");

            if (string.IsNullOrEmpty(nuevoValor))
            {
                MessageBox.Show("Ingrese un valor válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Config empresa = new();

            // Leer JSON si existe
            if (File.Exists(rutaJson))
            {
                string jsonExistente = File.ReadAllText(rutaJson);
                empresa = JsonSerializer.Deserialize<Config>(jsonExistente) ?? new Config();
            }

            // Modificar campo
            switch (campo)
            {
                // Direccion
                case 0:
                    empresa.Direccion = nuevoValor;
                    break;

                // Logo
                case 1:
                    if (LogoFile != null)
                    {
                        try
                        {
                            // Copiamos el archivo seleccionado al directorio raíz como Logo.png
                            string destino = Path.Combine(AppContext.BaseDirectory, "Logo.png");

                            // Si el usuario guardó el archivo en otro nombre, lo copiamos como Logo.png en raíz
                            File.Copy(LogoFile, destino, overwrite: true);

                            MessageBox.Show("Logo guardado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar un archivo como logo", "Logo no seleccionado",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

                // Nombre
                case 2:
                    empresa.Nombre = nuevoValor;
                    break;

                // Telefono
                case 3:
                    empresa.Telefono = nuevoValor;
                    break;
            }

            // Guardar de nuevo en JSON
            string json = JsonSerializer.Serialize(empresa, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaJson, json);

            MessageBox.Show("Información actualizada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
