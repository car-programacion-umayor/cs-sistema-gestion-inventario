using System;
using System.Windows.Forms;

namespace SistemaGestionInventario
{
    /// <summary>
    /// UserControl encargado de implementar la funcionalidad de ingreso de datos al sistema.
    /// </summary>
    public partial class UC_Agregar : UserControl
    {
        public UC_Agregar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestiona el registro de un nuevo producto tras validar los datos de la interfaz.
        /// </summary>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Captura y conversión de datos desde la Interfaz Gráfica de Usuario (GUI).
                int cod = int.Parse(txtCodigo.Text);
                string nom = txtNombre.Text;
                string tip = txtTipo.Text;
                double val = double.Parse(txtValor.Text);
                int exist = int.Parse(txtExistencia.Text);

                // 2. Se invoca el método de la clase Inventario para persistir el objeto en el ArrayList "Catalogo".
                Inventario.AgregarProducto(cod, nom, tip, val, exist);

                // 3. Notificación de éxito al usuario mediante ventana emergente.
                MessageBox.Show("Producto registrado exitosamente en el catálogo.");

                // 4. Se restablecen los controles de texto para permitir un nuevo ingreso.
                LimpiarFormulario();
            }
            catch (Exception)
            {
                // Manejo de excepciones para asegurar que los tipos de datos numéricos sean correctos.
                MessageBox.Show("Error: Verifique que el código, valor y existencia sean valores numéricos.");
            }
        }

        /// <summary>
        /// Método auxiliar para limpiar los cuadros de texto de la interfaz.
        /// </summary>
        private void LimpiarFormulario()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtTipo.Clear();
            txtValor.Clear();
            txtExistencia.Clear();
        }
    }
}
