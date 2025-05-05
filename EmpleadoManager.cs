using InkPos;
using System;
using System.Collections.Generic;

public class EmpleadoManager
{
    private Dictionary<string, Empleado> empleados = new Dictionary<string, Empleado>();

    public EmpleadoManager()
    {
        // Datos simulados para pruebas
        empleados.Add("E001", new Empleado { IdEmpleado = "E001", Nombre = "Juan", Telefono = "123456789", Cargo = "Cajero", Salario = 1000, Usuario = "juan123", Contrasena = "passjuan" });
    }

    public string ModificarEmpleado(Empleado empleado)
    {
        if (string.IsNullOrWhiteSpace(empleado.Nombre) ||
            string.IsNullOrWhiteSpace(empleado.Telefono) ||
            string.IsNullOrWhiteSpace(empleado.Cargo) ||
            empleado.Salario <= 0)
        {
            return "Advertencia: Hay campos vacíos o salario inválido.";
        }

        if (empleados.ContainsKey(empleado.IdEmpleado))
        {
            empleados[empleado.IdEmpleado] = empleado;
            return "Cambios guardados correctamente.";
        }
        else
        {
            return "Empleado no encontrado.";
        }
    }

    public Empleado BuscarEmpleado(string idEmpleado)
    {
        empleados.TryGetValue(idEmpleado, out Empleado empleado);
        return empleado;
    }

    // ✅ NUEVO: Registro de empleado
    public string RegistrarEmpleado(Empleado empleado)
    {
        if (string.IsNullOrWhiteSpace(empleado.Nombre) ||
            string.IsNullOrWhiteSpace(empleado.Telefono) ||
            string.IsNullOrWhiteSpace(empleado.Cargo) ||
            empleado.Salario <= 0 ||
            string.IsNullOrWhiteSpace(empleado.Usuario) ||
            string.IsNullOrWhiteSpace(empleado.Contrasena))
        {
            return "Advertencia: Hay campos faltantes.";
        }

        // Validar usuario único
        foreach (var e in empleados.Values)
        {
            if (e.Usuario == empleado.Usuario)
            {
                return "Advertencia: Usuario ya existente.";
            }
        }

        empleados.Add(empleado.IdEmpleado, empleado);
        return "Empleado guardado exitosamente.";
    }

    // ✅ NUEVO: Buscar empleado por usuario
    public Empleado BuscarPorUsuario(string usuario)
    {
        foreach (var empleado in empleados.Values)
        {
            if (empleado.Usuario == usuario)
            {
                return empleado;
            }
        }
        return null;
    }
}
