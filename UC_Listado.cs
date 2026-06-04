using System;
using System.Data;

namespace SistemaGestionInventario
{
    /// <summary>
    /// Control de usuario encargado de visualizar el listado completo de productos.
    /// Implementa la función de despliegue de datos del sistema.
    /// </summary>
    public partial class UC_Listado : UserControl
    {
        public UC_Listado()
        {
            InitializeComponent();
            CargarDatosInventario();
        }

        /// <summary>
        /// Método que vincula el arreglo dinámico Catalogo con el componente gráfico DataGridView.
        /// </summary>
        private void CargarDatosInventario()
        {
            // Se verifica que el arreglo dinámico contenga registros antes de realizar el despliegue.
            if (Inventario.Catalogo != null && Inventario.Catalogo.Count > 0)
            {
                // 1. Se limpian las columnas previas para asegurar una visualización actualizada.
                dgvProductos.Columns.Clear();

                // 2. Se habilita la generación automática de columnas basada en los atributos de Producto.
                dgvProductos.AutoGenerateColumns = true;

                // 3. Se asigna la fuente de datos transformando el ArrayList a una lista tipada.
                dgvProductos.DataSource = Inventario.Catalogo.Cast<Producto>().ToList();

                // 4. Se ajusta el modo de visualización de columnas para optimizar el espacio.
                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}