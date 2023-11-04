namespace AutomotrizApp.Presentacion
{
    partial class FrmConsultarPresupuestos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnReiniciarFiltros = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtPrecioProductoMax = new System.Windows.Forms.TextBox();
            this.txtPrecioProductoMin = new System.Windows.Forms.TextBox();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.dgvConsultarProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReiniciarFiltros
            // 
            this.btnReiniciarFiltros.Location = new System.Drawing.Point(561, 126);
            this.btnReiniciarFiltros.Name = "btnReiniciarFiltros";
            this.btnReiniciarFiltros.Size = new System.Drawing.Size(107, 23);
            this.btnReiniciarFiltros.TabIndex = 15;
            this.btnReiniciarFiltros.Text = "Reiniciar Filtros";
            this.btnReiniciarFiltros.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(683, 126);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 14;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(358, 25);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Listado de Presupuestos (sin hacer)";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTipoProducto.Location = new System.Drawing.Point(61, 126);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(31, 15);
            this.lblTipoProducto.TabIndex = 18;
            this.lblTipoProducto.Text = "Tipo";
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblPrecioProducto.Location = new System.Drawing.Point(50, 91);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(42, 15);
            this.lblPrecioProducto.TabIndex = 16;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(98, 125);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(237, 21);
            this.cboTipoProducto.TabIndex = 13;
            // 
            // txtPrecioProductoMax
            // 
            this.txtPrecioProductoMax.Location = new System.Drawing.Point(235, 90);
            this.txtPrecioProductoMax.Name = "txtPrecioProductoMax";
            this.txtPrecioProductoMax.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProductoMax.TabIndex = 11;
            // 
            // txtPrecioProductoMin
            // 
            this.txtPrecioProductoMin.Location = new System.Drawing.Point(98, 90);
            this.txtPrecioProductoMin.Name = "txtPrecioProductoMin";
            this.txtPrecioProductoMin.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProductoMin.TabIndex = 10;
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblNombreProducto.Location = new System.Drawing.Point(40, 56);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(52, 15);
            this.lblNombreProducto.TabIndex = 12;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNombreProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombreProducto.Location = new System.Drawing.Point(98, 55);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(237, 20);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // dgvConsultarProductos
            // 
            this.dgvConsultarProductos.AllowUserToAddRows = false;
            this.dgvConsultarProductos.AllowUserToDeleteRows = false;
            this.dgvConsultarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultarProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombreProducto,
            this.precioProducto,
            this.tipoProducto,
            this.Editar});
            this.dgvConsultarProductos.Location = new System.Drawing.Point(12, 164);
            this.dgvConsultarProductos.Name = "dgvConsultarProductos";
            this.dgvConsultarProductos.ReadOnly = true;
            this.dgvConsultarProductos.RowHeadersVisible = false;
            this.dgvConsultarProductos.Size = new System.Drawing.Size(746, 346);
            this.dgvConsultarProductos.TabIndex = 17;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            // 
            // precioProducto
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.precioProducto.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // tipoProducto
            // 
            this.tipoProducto.HeaderText = "Tipo";
            this.tipoProducto.Name = "tipoProducto";
            this.tipoProducto.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Editar.HeaderText = "Accion";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Width = 65;
            // 
            // FrmConsultarPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(770, 520);
            this.Controls.Add(this.btnReiniciarFiltros);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTipoProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.txtPrecioProductoMax);
            this.Controls.Add(this.txtPrecioProductoMin);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.dgvConsultarProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarPresupuestos";
            this.Text = "FrmConsultarPresupuestos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReiniciarFiltros;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.TextBox txtPrecioProductoMax;
        private System.Windows.Forms.TextBox txtPrecioProductoMin;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.DataGridView dgvConsultarProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProducto;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}