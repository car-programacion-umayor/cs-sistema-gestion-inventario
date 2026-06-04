namespace SistemaGestionInventario
{
    partial class UC_Consultar
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtCodigoBusqueda = new TextBox();
            btnConsultar = new Button();
            lblInstruccionBusqueda = new Label();
            SuspendLayout();
            // 
            // txtCodigoBusqueda
            // 
            txtCodigoBusqueda.Location = new Point(152, 113);
            txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            txtCodigoBusqueda.Size = new Size(346, 23);
            txtCodigoBusqueda.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(241, 157);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(136, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "BUSCAR PRODUCTO";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblInstruccionBusqueda
            // 
            lblInstruccionBusqueda.AutoSize = true;
            lblInstruccionBusqueda.Location = new Point(173, 65);
            lblInstruccionBusqueda.Name = "lblInstruccionBusqueda";
            lblInstruccionBusqueda.Size = new Size(299, 15);
            lblInstruccionBusqueda.TabIndex = 2;
            lblInstruccionBusqueda.Text = "Ingrese el código o el nombre del producto para buscar";
            // 
            // UC_Consultar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblInstruccionBusqueda);
            Controls.Add(txtCodigoBusqueda);
            Controls.Add(btnConsultar);
            Name = "UC_Consultar";
            Size = new Size(841, 277);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigoBusqueda;
        private Button btnConsultar;
        private Label lblInstruccionBusqueda;
    }
}
