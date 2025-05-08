namespace InkPos
{
    /// <summary>
    /// Clase que contiene a todas las excepciones que se presentan en InkPos. <br/>
    /// Cada excepcion definida mostrara un cuadro de dialogo informando de la excepcion.
    /// </summary>
    internal class Excepciones
    {
        /// <summary>
        /// Excepcion producida cuando existen campos vacios en un formulario. <br/>
        /// Nivel de Excepcion: Advertencia
        /// </summary>
        public class CamposVacios : Exception
        {
            public CamposVacios()
            {
                MessageBox.Show("Existen Campos vacios. Por favor rellene todos los campos.", "Campos Vacios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Excepcion producida cuando se intenta buscar un empleado con un usuario<br/>
        /// que no esta registrado en la base de datos.<br/>
        /// Nivel de Excepcion: Advertencia.
        /// </summary>
        public class EmpleadoInexistente : Exception
        {
            public EmpleadoInexistente()
            {
                MessageBox.Show("No existe un empleado con el Usuario dado.", "Usuario Inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Excepcion producida cuando la contraseña de un empleado no coincide con el<br/>
        /// Hash almacenado en la base de datos.
        /// </summary>
        public class ContraseñaEmpleadoIncorrecta : Exception
        {
            public ContraseñaEmpleadoIncorrecta() 
            {
                MessageBox.Show("La contraseña proporcinada es incorrecta para el usuario", 
                    "Usuario o Contraseña incorrecta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
