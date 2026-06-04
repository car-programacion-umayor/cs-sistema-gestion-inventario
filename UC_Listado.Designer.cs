namespace SistemaGestionInventario
{
    partial class UC_Listado
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
            dgvProductos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colExistencia = new DataGridViewTextBoxColumn();
            lblTituloListado = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToOrderColumns = true;
            dgvProductos.BackgroundColor = SystemColors.ControlLightLight;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNombre, colTipo, colValor, colExistencia });
            dgvProductos.GridColor = SystemColors.InfoText;
            dgvProductos.Location = new Point(49, 66);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(537, 260);
            dgvProductos.TabIndex = 0;
            // 
            // colCodigo
            // 
            colCodigo.DataPropertyName = "Codigo";
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            colNombre.DataPropertyName = "Nombre";
            colNombre.HeaderText = "Nombre";
            colNombre.Name = "colNombre";
            // 
            // colTipo
            // 
            colTipo.DataPropertyName = "Tipo";
            colTipo.HeaderText = "Tipo";
            colTipo.Name = "colTipo";
            // 
            // colValor
            // 
            colValor.DataPropertyName = "Valor";
            colValor.HeaderText = "Valor";
            colValor.Name = "colValor";
            // 
            // colExistencia
            // 
            colExistencia.DataPropertyName = "Existencia";
            colExistencia.HeaderText = "Existencia";
            colExistencia.Name = "colExistencia";
            // 
            // lblTituloListado
            // 
            lblTituloListado.AutoSize = true;
            lblTituloListado.Location = new Point(233, 30);
            lblTituloListado.Name = "lblTituloListado";
            lblTituloListado.Size = new Size(102, 15);
            lblTituloListado.TabIndex = 1;
            lblTituloListado.Text = "Inventario general";
            // 
            // UC_Listado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTituloListado);
            Controls.Add(dgvProductos);
            Name = "UC_Listado";
            Padding = new Padding(0, 30, 0, 0);
            Size = new Size(627, 339);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colValor;
        private DataGridViewTextBoxColumn colExistencia;
        private Label lblTituloListado;
    }
}
