using InkPos;
using System;
using System.Collections.Generic;

public class EmpleadoManager
{
    private Dictionary<string, Empleado> empleados = new Dictionary<string, Empleado>();

    public EmpleadoManager()
    {
        // Datos simulados para pruebas
        empleados.Add("E001", new Empleado { IdEmpleado = "E001", Nombre = "Juan", Telefono = "123456789", Cargo = "Cajero", Salario = 1000 });
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
}
