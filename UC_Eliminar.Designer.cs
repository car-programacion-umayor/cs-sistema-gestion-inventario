namespace SistemaGestionInventario
{
    partial class UC_Eliminar
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
            lblCodEliminar = new Label();
            txtCodEliminar = new TextBox();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lblCodEliminar
            // 
            lblCodEliminar.AutoSize = true;
            lblCodEliminar.Location = new Point(192, 61);
            lblCodEliminar.Name = "lblCodEliminar";
            lblCodEliminar.Size = new Size(175, 15);
            lblCodEliminar.TabIndex = 0;
            lblCodEliminar.Text = "Código del producto a eliminar:";
            // 
            // txtCodEliminar
            // 
            txtCodEliminar.Location = new Point(192, 100);
            txtCodEliminar.Name = "txtCodEliminar";
            txtCodEliminar.Size = new Size(186, 23);
            txtCodEliminar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(214, 145);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "ELIMINAR REGISTRO";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // UC_Eliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblCodEliminar);
            Controls.Add(txtCodEliminar);
            Controls.Add(btnEliminar);
            Name = "UC_Eliminar";
            Size = new Size(619, 348);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodEliminar;
        private TextBox txtCodEliminar;
        private Button btnEliminar;
    }
}
