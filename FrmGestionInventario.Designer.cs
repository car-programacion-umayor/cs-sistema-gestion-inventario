namespace SistemaGestionInventario
{
    partial class FrmGestionInventario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlPrincipal = new Panel();
            menuStrip1 = new MenuStrip();
            menuAgregar = new ToolStripMenuItem();
            menuListado = new ToolStripMenuItem();
            menuConsultar = new ToolStripMenuItem();
            menuModificar = new ToolStripMenuItem();
            menuEliminar = new ToolStripMenuItem();
            menuSimularVenta = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 0);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(800, 450);
            pnlPrincipal.TabIndex = 24;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuAgregar, menuListado, menuConsultar, menuModificar, menuEliminar, menuSimularVenta });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuAgregar
            // 
            menuAgregar.Name = "menuAgregar";
            menuAgregar.Size = new Size(113, 20);
            menuAgregar.Text = "Agregar producto";
            menuAgregar.Click += menuAgregar_Click;
            // 
            // menuListado
            // 
            menuListado.Name = "menuListado";
            menuListado.Size = new Size(130, 20);
            menuListado.Text = "Listado de productos";
            menuListado.Click += menuListado_Click;
            // 
            // menuConsultar
            // 
            menuConsultar.Name = "menuConsultar";
            menuConsultar.Size = new Size(122, 20);
            menuConsultar.Text = "Consultar producto";
            menuConsultar.Click += menuConsultar_Click;
            // 
            // menuModificar
            // 
            menuModificar.Name = "menuModificar";
            menuModificar.Size = new Size(113, 20);
            menuModificar.Text = "Modificar registro";
            menuModificar.Click += menuModificar_Click;
            // 
            // menuEliminar
            // 
            menuEliminar.Name = "menuEliminar";
            menuEliminar.Size = new Size(105, 20);
            menuEliminar.Text = "Eliminar registro";
            menuEliminar.Click += menuEliminar_Click;
            // 
            // menuSimularVenta
            // 
            menuSimularVenta.Name = "menuSimularVenta";
            menuSimularVenta.Size = new Size(114, 20);
            menuSimularVenta.Text = "Simular una venta";
            menuSimularVenta.Click += menuSimularVenta_Click;
            // 
            // FrmGestionInventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(pnlPrincipal);
            Name = "FrmGestionInventario";
            Text = "Sistema de Gestión de Inventario - Carmen Araya";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlPrincipal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuAgregar;
        private ToolStripMenuItem menuListado;
        private ToolStripMenuItem menuConsultar;
        private ToolStripMenuItem menuModificar;
        private ToolStripMenuItem menuEliminar;
        private ToolStripMenuItem menuSimularVenta;
    }
}
