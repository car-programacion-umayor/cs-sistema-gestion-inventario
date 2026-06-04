using System;

namespace SistemaGestionInventario
{
    /// <summary>
    /// Control de usuario encargado de la búsqueda y consulta de productos en el catálogo.
    /// Implementa la lógica de filtrado por código o nombre.
    /// </summary>
    public partial class UC_Consultar : UserControl
    {
        public UC_Consultar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gestiona el evento de búsqueda de un producto específico dentro del ArrayList.
        /// </summary>
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // 1. Obtención y normalización del término de búsqueda ingresado en la GUI.
            string busqueda = txtCodigoBusqueda.Text.ToLower().Trim();
            bool encontrado = false;

            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Por favor, ingrese un criterio de búsqueda (Código o Nombre).");
                return;
            }

            // 2. Iteración sobre la estructura dinámica Catalogo para localizar la coincidencia.
            foreach (Producto p in Inventario.Catalogo)
            {
                // Validación de coincidencia exacta por código o parcial por nombre.
                if (p.Codigo.ToString() == busqueda || p.Nombre.ToLower().Contains(busqueda))
                {
                    // 3. Despliegue de la información detallada del producto encontrado.
                    MessageBox.Show($"DETALLES DEL PRODUCTO:\n\n" +
                                    $"Código: {p.Codigo}\n" +
                                    $"Nombre: {p.Nombre}\n" +
                                    $"Tipo: {p.Tipo}\n" +
                                    $"Precio: ${p.Valor}\n" +
                                    $"Existencia: {p.Existencia}", "Resultado de la Consulta");
                    encontrado = true;
                    break;
                }
            }

            // 4. Manejo de la notificación en caso de no hallar registros coincidentes.
            if (!encontrado)
            {
                MessageBox.Show($"No se han encontrado registros para el criterio ingresado: {busqueda}", "Sin resultados");
            }
        }
    }
}
