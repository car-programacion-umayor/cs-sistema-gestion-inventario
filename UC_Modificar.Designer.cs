namespace SistemaGestionInventario
{
    partial class UC_Modificar
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
            lblCodBuscar = new Label();
            txtCodBuscar = new TextBox();
            btnBuscarMod = new Button();
            lblNuevoNombre = new Label();
            txtNuevoNombre = new TextBox();
            lblNuevoTipo = new Label();
            lblNuevoValor = new Label();
            lblNuevaExistencia = new Label();
            txtNuevoTipo = new TextBox();
            txtNuevoValor = new TextBox();
            txtNuevaExistencia = new TextBox();
            btnGuardarCambios = new Button();
            lblTituloModificar = new Label();
            SuspendLayout();
            // 
            // lblCodBuscar
            // 
            lblCodBuscar.AutoSize = true;
            lblCodBuscar.Location = new Point(50, 118);
            lblCodBuscar.Name = "lblCodBuscar";
            lblCodBuscar.Size = new Size(120, 15);
            lblCodBuscar.TabIndex = 0;
            lblCodBuscar.Text = "Código del producto:";
            // 
            // txtCodBuscar
            // 
            txtCodBuscar.Location = new Point(198, 110);
            txtCodBuscar.Name = "txtCodBuscar";
            txtCodBuscar.Size = new Size(121, 23);
            txtCodBuscar.TabIndex = 1;
            // 
            // btnBuscarMod
            // 
            btnBuscarMod.Location = new Point(356, 110);
            btnBuscarMod.Name = "btnBuscarMod";
            btnBuscarMod.Size = new Size(75, 23);
            btnBuscarMod.TabIndex = 2;
            btnBuscarMod.Text = "BUSCAR";
            btnBuscarMod.UseVisualStyleBackColor = true;
            btnBuscarMod.Click += btnBuscarMod_Click;
            // 
            // lblNuevoNombre
            // 
            lblNuevoNombre.AutoSize = true;
            lblNuevoNombre.Location = new Point(50, 160);
            lblNuevoNombre.Name = "lblNuevoNombre";
            lblNuevoNombre.Size = new Size(90, 15);
            lblNuevoNombre.TabIndex = 3;
            lblNuevoNombre.Text = "Nuevo nombre:";
            // 
            // txtNuevoNombre
            // 
            txtNuevoNombre.Location = new Point(198, 152);
            txtNuevoNombre.Name = "txtNuevoNombre";
            txtNuevoNombre.Size = new Size(167, 23);
            txtNuevoNombre.TabIndex = 4;
            // 
            // lblNuevoTipo
            // 
            lblNuevoTipo.AutoSize = true;
            lblNuevoTipo.Location = new Point(50, 189);
            lblNuevoTipo.Name = "lblNuevoTipo";
            lblNuevoTipo.Size = new Size(69, 15);
            lblNuevoTipo.TabIndex = 5;
            lblNuevoTipo.Text = "Nuevo tipo:";
            // 
            // lblNuevoValor
            // 
            lblNuevoValor.AutoSize = true;
            lblNuevoValor.Location = new Point(50, 220);
            lblNuevoValor.Name = "lblNuevoValor";
            lblNuevoValor.Size = new Size(118, 15);
            lblNuevoValor.TabIndex = 6;
            lblNuevoValor.Text = "Nuevo valor unitario:";
            // 
            // lblNuevaExistencia
            // 
            lblNuevaExistencia.AutoSize = true;
            lblNuevaExistencia.Location = new Point(48, 251);
            lblNuevaExistencia.Name = "lblNuevaExistencia";
            lblNuevaExistencia.Size = new Size(98, 15);
            lblNuevaExistencia.TabIndex = 7;
            lblNuevaExistencia.Text = "Nueva existencia:";
            // 
            // txtNuevoTipo
            // 
            txtNuevoTipo.Location = new Point(198, 181);
            txtNuevoTipo.Name = "txtNuevoTipo";
            txtNuevoTipo.Size = new Size(167, 23);
            txtNuevoTipo.TabIndex = 8;
            // 
            // txtNuevoValor
            // 
            txtNuevoValor.Location = new Point(198, 212);
            txtNuevoValor.Name = "txtNuevoValor";
            txtNuevoValor.Size = new Size(167, 23);
            txtNuevoValor.TabIndex = 9;
            // 
            // txtNuevaExistencia
            // 
            txtNuevaExistencia.Location = new Point(198, 243);
            txtNuevaExistencia.Name = "txtNuevaExistencia";
            txtNuevaExistencia.Size = new Size(167, 23);
            txtNuevaExistencia.TabIndex = 10;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.Location = new Point(128, 290);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(156, 23);
            btnGuardarCambios.TabIndex = 11;
            btnGuardarCambios.Text = "GUARDAR CAMBIOS";
            btnGuardarCambios.UseVisualStyleBackColor = true;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // lblTituloModificar
            // 
            lblTituloModificar.AutoSize = true;
            lblTituloModificar.Location = new Point(177, 59);
            lblTituloModificar.Name = "lblTituloModificar";
            lblTituloModificar.Size = new Size(142, 15);
            lblTituloModificar.TabIndex = 12;
            lblTituloModificar.Text = "Actualización de registros";
            // 
            // UC_Modificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTituloModificar);
            Controls.Add(lblCodBuscar);
            Controls.Add(txtCodBuscar);
            Controls.Add(btnBuscarMod);
            Controls.Add(lblNuevoNombre);
            Controls.Add(txtNuevoNombre);
            Controls.Add(lblNuevoTipo);
            Controls.Add(txtNuevoTipo);
            Controls.Add(lblNuevoValor);
            Controls.Add(txtNuevoValor);
            Controls.Add(lblNuevaExistencia);
            Controls.Add(txtNuevaExistencia);
            Controls.Add(btnGuardarCambios);
            Name = "UC_Modificar";
            Size = new Size(629, 349);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodBuscar;
        private TextBox txtCodBuscar;
        private Button btnBuscarMod;
        private Label lblNuevoNombre;
        private TextBox txtNuevoNombre;
        private Label lblNuevoTipo;
        private Label lblNuevoValor;
        private Label lblNuevaExistencia;
        private TextBox txtNuevoTipo;
        private TextBox txtNuevoValor;
        private TextBox txtNuevaExistencia;
        private Button btnGuardarCambios;
        private Label lblTituloModificar;
    }
}
