namespace InkPos
{

    internal class Excepciones
    {

        public class CamposVacios : Exception
        {
            public CamposVacios()
            {
                MessageBox.Show("Existen Campos vacios. Por favor rellene todos los campos.", "Campos Vacios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class EmpleadoInexistente : Exception
        {
            public EmpleadoInexistente()
            {
                MessageBox.Show("No existe un empleado con el Usuario dado.", "Usuario Inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class ContraseñaEmpleadoIncorrecta : Exception
        {
            public ContraseñaEmpleadoIncorrecta() 
            {
                MessageBox.Show("La contraseña proporcinada es incorrecta para el usuario", 
                    "Usuario o Contraseña incorrecta",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        public class ProductoInexistente : Exception 
        {
            public ProductoInexistente()
            {
                MessageBox.Show("El producto no existe en la Base de Datos.", 
                    "Producto Inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        public class ProductoExistente : Exception
        {
            public ProductoExistente()
            {
                MessageBox.Show("El producto ya esta registrado en la Base de Datos.", 
                    "Producto Ya Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
