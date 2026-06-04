using System;
using System.Windows.Forms;

namespace SistemaGestionInventario
{
    /// <summary>
    /// Control de usuario que gestiona la eliminación de registros del catálogo.
    /// Implementa la validación y confirmación de baja de productos.
    /// </summary>
    public partial class UC_Eliminar : UserControl
    {
        public UC_Eliminar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procesa la búsqueda y remoción de un producto del ArrayList utilizando su identificador numérico (código).
        /// </summary>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validación de entrada para asegurar que el campo no esté vacío.
            if (string.IsNullOrEmpty(txtCodEliminar.Text))
            {
                MessageBox.Show("Por favor, ingrese el código del producto para proceder.");
                return;
            }

            try
            {
                // 2. Conversión del identificador y búsqueda en la estructura dinámica.
                int codigoABuscar = int.Parse(txtCodEliminar.Text);
                Producto? productoAEliminar = null;

                foreach (Producto p in Inventario.Catalogo)
                {
                    if (p.Codigo == codigoABuscar)
                    {
                        productoAEliminar = p;
                        break;
                    }
                }

                // 3. Verificación de existencia y solicitud de confirmación de seguridad.
                if (productoAEliminar != null)
                {
                    DialogResult respuesta = MessageBox.Show(
                        $"¿Confirma la eliminación del producto: '{productoAEliminar.Nombre}'?",
                        "Confirmar Acción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    // 4. Ejecución de la remoción en el ArrayList si el usuario confirma.
                    if (respuesta == DialogResult.Yes)
                    {
                        Inventario.Catalogo.Remove(productoAEliminar);
                        MessageBox.Show("Registro eliminado exitosamente del catálogo.");
                        txtCodEliminar.Clear();
                    }
                }
                else
                {
                    MessageBox.Show($"No se ha localizado ningún producto con el código: {codigoABuscar}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: El código ingresado debe ser un valor numérico.");
            }
        }
    }
}