using System;
using System.Windows.Forms;

namespace SistemaGestionInventario
{
    /// <summary>
    /// Control de usuario que gestiona la simulación de transacciones comerciales.
    /// Realiza la validación de inventario y la actualización del stock disponible.
    /// </summary>
    public partial class UC_Venta : UserControl
    {
        public UC_Venta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Procesa el requerimiento de venta, validando existencias y calculando el total a pagar.
        /// </summary>
        private void btnVenta_Click(object sender, EventArgs e)
        {
            // 1. Verificación de campos obligatorios en la interfaz gráfica.
            if (string.IsNullOrEmpty(txtCodVenta.Text) || string.IsNullOrEmpty(txtCantVenta.Text))
            {
                MessageBox.Show("Por favor, ingrese el código y la cantidad para proceder con la venta.");
                return;
            }

            try
            {
                // 2. Conversión de datos de entrada desde la GUI.
                int codigoBuscado = int.Parse(txtCodVenta.Text);
                int cantidadAVender = int.Parse(txtCantVenta.Text);
                bool encontrado = false;

                // 3. Iteración en la estructura dinámica Catalogo para localizar el registro.
                foreach (Producto p in Inventario.Catalogo)
                {
                    if (p.Codigo == codigoBuscado)
                    {
                        encontrado = true;

                        // 4. Validación de stock disponible según requerimientos de negocio.
                        if (p.Existencia >= cantidadAVender)
                        {
                            // Cálculo del monto total y actualización del atributo Existencia.
                            double totalPagar = cantidadAVender * p.Valor;
                            p.Existencia -= cantidadAVender;

                            // 5. Despliegue del comprobante detallado de la operación.
                            MessageBox.Show("VENTA REALIZADA CON ÉXITO\n\n" +
                                            $"Producto: {p.Nombre}\n" +
                                            $"Precio Unitario: ${p.Valor:N0}\n" +
                                            $"Cantidad Vendida: {cantidadAVender}\n" +
                                            "------------------------------------------\n" +
                                            $"TOTAL A PAGAR: ${totalPagar:N0}",
                                            "Comprobante de Venta");

                            // Restablecimiento de los controles para una nueva operación.
                            txtCodVenta.Clear();
                            txtCantVenta.Clear();
                        }
                        else
                        {
                            // Notificación de insuficiencia de stock.
                            MessageBox.Show($"STOCK INSUFICIENTE\n\nEl producto '{p.Nombre}' solo dispone de {p.Existencia} unidades.");
                        }
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show($"El código de producto '{codigoBuscado}' no se encuentra en el catálogo.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Ingrese únicamente valores numéricos enteros en Código y Cantidad.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado en el procesamiento: " + ex.Message);
            }
        }
    }
}