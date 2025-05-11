namespace InkPos
{

    internal class Excepciones
    {

        //      #### General
        public class CamposVacios : Exception
        {
            public CamposVacios()
            {
                MessageBox.Show("Existen Campos vacios. Por favor rellene todos los campos.", "Campos Vacios",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //      #### Producto

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
    
        //      #### Empleado
        public class EmpleadoInexistente : Exception
        {
            public EmpleadoInexistente()
            {
                MessageBox.Show("No existe un empleado con el Usuario dado.", "Usuario Inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class EmpleadoExistente : Exception
        {
            public EmpleadoExistente()
            {
                MessageBox.Show("El Empleado ya existe en la base de datos", 
                    "Empleado Ya Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class UsuarioEmpleadoExistente : Exception
        {
            public UsuarioEmpleadoExistente()
            {
                MessageBox.Show("Ya existe un empleado con ese Usuario", 
                    "Usuario Existente",
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
    
        //      #### Devolucion
        public class DevolucionExistente : Exception
        {
            public DevolucionExistente()
            {
                MessageBox.Show("La devolucion ya esta registrada en la Base de Datos", 
                    "Devolucion Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class DevolucionInexistente : Exception
        {
            public DevolucionInexistente()
            {
                MessageBox.Show("La devolucion no se encuantra en la Base de Datos", 
                    "Devolucion Inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        //      #### Factura

        public class FacturaInexistente : Exception
        {
            public FacturaInexistente()
            {
                MessageBox.Show("La factura solicitada no existe en la Base de Datos", 
                    "Factura Inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        public class FacturaExistente : Exception
        {
            public FacturaExistente()
            {
                MessageBox.Show("La factura ya esta registrada en la base de datos", 
                    "Factura Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        //      #### Detalle
        public class DetalleExistente : Exception
        {
            public DetalleExistente()
            {
                MessageBox.Show("La factura ya tiene un producto agregado del mismo tipo", 
                    "Detalle Existente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    
        public class DetalleInexistente
        {
            public DetalleInexistente()
            {
                MessageBox.Show("El producto no se encuentra registrado en la factura", 
                    "Detalle Inexistente",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
