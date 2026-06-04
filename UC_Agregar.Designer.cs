namespace SistemaGestionInventario
{
    partial class UC_Agregar
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
            lblExistencia = new Label();
            btnRegistrar = new Button();
            lblCodigo = new Label();
            txtTipo = new TextBox();
            txtExistencia = new TextBox();
            lblValor = new Label();
            txtCodigo = new TextBox();
            txtValor = new TextBox();
            txtNombre = new TextBox();
            lblTipo = new Label();
            lblNombre = new Label();
            lblTituloAgregar = new Label();
            SuspendLayout();
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Location = new Point(99, 236);
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(58, 15);
            lblExistencia.TabIndex = 28;
            lblExistencia.Text = "Existencia";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(217, 273);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(150, 23);
            btnRegistrar.TabIndex = 34;
            btnRegistrar.Text = "REGISTRAR PRODUCTO";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(99, 110);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 24;
            lblCodigo.Text = "Código";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(185, 169);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(240, 23);
            txtTipo.TabIndex = 31;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(185, 236);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(240, 23);
            txtExistencia.TabIndex = 33;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(99, 207);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(78, 15);
            lblValor.TabIndex = 27;
            lblValor.Text = "Valor Unitario";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(185, 102);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(240, 23);
            txtCodigo.TabIndex = 29;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(185, 204);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(240, 23);
            txtValor.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(185, 136);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 23);
            txtNombre.TabIndex = 30;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(99, 172);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 26;
            lblTipo.Text = "Tipo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(99, 144);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 25;
            lblNombre.Text = "Nombre";
            // 
            // lblTituloAgregar
            // 
            lblTituloAgregar.AutoSize = true;
            lblTituloAgregar.Location = new Point(197, 42);
            lblTituloAgregar.Name = "lblTituloAgregar";
            lblTituloAgregar.Size = new Size(123, 15);
            lblTituloAgregar.TabIndex = 35;
            lblTituloAgregar.Text = "Registro de productos";
            // 
            // UC_Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTituloAgregar);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblTipo);
            Controls.Add(txtTipo);
            Controls.Add(lblValor);
            Controls.Add(txtValor);
            Controls.Add(lblExistencia);
            Controls.Add(txtExistencia);
            Controls.Add(btnRegistrar);
            Name = "UC_Agregar";
            Size = new Size(467, 318);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExistencia;
        private Button btnRegistrar;
        private Label lblCodigo;
        private TextBox txtTipo;
        private TextBox txtExistencia;
        private Label lblValor;
        private TextBox txtCodigo;
        private TextBox txtValor;
        private TextBox txtNombre;
        private Label lblTipo;
        private Label lblNombre;
        private Label lblTituloAgregar;
    }
}
