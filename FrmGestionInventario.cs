using System;
using System.Windows.Forms;

namespace SistemaGestionInventario
{
    /// <summary>
    /// Formulario principal que actúa como contenedor de la interfaz de usuario.
    /// Gestiona la navegación entre los diferentes módulos del sistema mediante el intercambio de User Controls.
    /// </summary>
    public partial class FrmGestionInventario : Form
    {
        public FrmGestionInventario()
        {
            InitializeComponent();

            // Configuración de la vista inicial: Carga automática del módulo de registro al ejecutar la aplicación.
            UC_Agregar vistaInicial = new UC_Agregar();
            vistaInicial.Dock = DockStyle.Fill;

            pnlPrincipal.Controls.Clear();
            pnlPrincipal.Controls.Add(vistaInicial);
        }

        /// <summary>
        /// Realiza el intercambio dinámico en el panel contenedor para mostrar el módulo de Registro.
        /// </summary>
        private void menuAgregar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            UC_Agregar vista = new UC_Agregar();
            vista.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(vista);
        }

        /// <summary>
        /// Realiza el intercambio dinámico en el panel contenedor para mostrar el Listado General.
        /// </summary>
        private void menuListado_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            UC_Listado vistaLista = new UC_Listado();
            vistaLista.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(vistaLista);
        }

        /// <summary>
        /// Realiza el intercambio dinámico en el panel contenedor para mostrar el módulo de Consultas.
        /// </summary>
        private void menuConsultar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            UC_Consultar vistaConsulta = new UC_Consultar();
            vistaConsulta.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(vistaConsulta);
        }

        /// <summary>
        /// Realiza el intercambio dinámico en el panel contenedor para mostrar el módulo de Modificación.
        /// </summary>
        private void menuModificar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            UC_Modificar ventanaModificar = new UC_Modificar();
            ventanaModificar.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(ventanaModificar);
        }

        /// <summary>
        /// Realiza el intercambio dinámico en el panel contenedor para mostrar el módulo de Eliminación.
        /// </summary>
        private void menuEliminar_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            UC_Eliminar pantallaEliminar = new UC_Eliminar();
            pantallaEliminar.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(pantallaEliminar);
        }

        /// <summary>
        /// Realiza el intercambio dinámico en el panel contenedor para mostrar el módulo de Ventas.
        /// </summary>
        private void menuSimularVenta_Click(object sender, EventArgs e)
        {
            pnlPrincipal.Controls.Clear();
            UC_Venta pantallaVenta = new UC_Venta();
            pantallaVenta.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(pantallaVenta);
        }
    }
}