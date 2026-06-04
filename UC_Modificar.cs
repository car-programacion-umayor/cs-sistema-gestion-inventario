using System;
using System.Windows.Forms;

namespace SistemaGestionInventario
{
    /// <summary>
    /// Control de usuario que gestiona la actualización de información de productos existentes.
    /// Implementa la búsqueda y sobreescritura de atributos en el ArrayList Catalogo.
    /// </summary>
    public partial class UC_Modificar : UserControl
    {
        public UC_Modificar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Localiza el producto por su identificador y despliega sus datos actuales en la interfaz.
        /// </summary>
        private void btnBuscarMod_Click(object sender, EventArgs e)
        {
            try
            {
                int codigoABuscar = int.Parse(txtCodBuscar.Text);
                bool encontrado = false;

                foreach (Producto p in Inventario.Catalogo)
                {
                    if (p.Codigo == codigoABuscar)
                    {
                        // Despliegue de la información actual en los controles de edición
                        txtNuevoNombre.Text = p.Nombre;
                        txtNuevoTipo.Text = p.Tipo;
                        txtNuevoValor.Text = p.Valor.ToString();
                        txtNuevaExistencia.Text = p.Existencia.ToString();

                        encontrado = true;
                        MessageBox.Show("Registro localizado. Puede proceder con la edición.");
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("El código ingresado no existe en el catálogo.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Ingrese un código numérico para realizar la búsqueda.");
            }
        }

        /// <summary>
        /// Aplica los cambios realizados en la GUI directamente sobre el objeto referenciado en el ArrayList.
        /// </summary>
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(txtCodBuscar.Text);
                bool actualizado = false;

                foreach (Producto p in Inventario.Catalogo)
                {
                    if (p.Codigo == codigo)
                    {
                        // Actualización de los atributos del objeto referenciado
                        p.Nombre = txtNuevoNombre.Text;
                        p.Tipo = txtNuevoTipo.Text;
                        p.Valor = double.Parse(txtNuevoValor.Text);
                        p.Existencia = int.Parse(txtNuevaExistencia.Text);

                        actualizado = true;
                        MessageBox.Show("Los cambios han sido guardados exitosamente.");
                        break;
                    }
                }

                if (!actualizado)
                {
                    MessageBox.Show("No se pudo completar la operación. Verifique que el producto haya sido buscado previamente.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Verifique que los campos de Precio y Existencia contengan valores numéricos.");
            }
        }
    }
}
