namespace SistemaGestionInventario
{
    partial class UC_Venta
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
            lblCodVenta = new Label();
            lblCantVenta = new Label();
            txtCodVenta = new TextBox();
            txtCantVenta = new TextBox();
            btnVenta = new Button();
            lblTituloVenta = new Label();
            SuspendLayout();
            // 
            // lblCodVenta
            // 
            lblCodVenta.AutoSize = true;
            lblCodVenta.Location = new Point(68, 104);
            lblCodVenta.Name = "lblCodVenta";
            lblCodVenta.Size = new Size(120, 15);
            lblCodVenta.TabIndex = 0;
            lblCodVenta.Text = "Código del producto:";
            // 
            // lblCantVenta
            // 
            lblCantVenta.AutoSize = true;
            lblCantVenta.Location = new Point(68, 134);
            lblCantVenta.Name = "lblCantVenta";
            lblCantVenta.Size = new Size(106, 15);
            lblCantVenta.TabIndex = 1;
            lblCantVenta.Text = "Cantidad a vender:";
            // 
            // txtCodVenta
            // 
            txtCodVenta.Location = new Point(213, 96);
            txtCodVenta.Name = "txtCodVenta";
            txtCodVenta.Size = new Size(100, 23);
            txtCodVenta.TabIndex = 2;
            // 
            // txtCantVenta
            // 
            txtCantVenta.Location = new Point(213, 125);
            txtCantVenta.Name = "txtCantVenta";
            txtCantVenta.Size = new Size(100, 23);
            txtCantVenta.TabIndex = 3;
            // 
            // btnVenta
            // 
            btnVenta.Location = new Point(138, 175);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(132, 23);
            btnVenta.TabIndex = 4;
            btnVenta.Text = "REALIZAR VENTA";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // lblTituloVenta
            // 
            lblTituloVenta.AutoSize = true;
            lblTituloVenta.Location = new Point(138, 44);
            lblTituloVenta.Name = "lblTituloVenta";
            lblTituloVenta.Size = new Size(101, 15);
            lblTituloVenta.TabIndex = 5;
            lblTituloVenta.Text = "Sistema de ventas";
            // 
            // UC_Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTituloVenta);
            Controls.Add(lblCodVenta);
            Controls.Add(txtCodVenta);
            Controls.Add(lblCantVenta);
            Controls.Add(txtCantVenta);
            Controls.Add(btnVenta);
            Name = "UC_Venta";
            Size = new Size(734, 393);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodVenta;
        private Label lblCantVenta;
        private TextBox txtCodVenta;
        private TextBox txtCantVenta;
        private Button btnVenta;
        private Label lblTituloVenta;
    }
}
