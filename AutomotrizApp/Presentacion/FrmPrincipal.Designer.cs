namespace AutomotrizApp
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnMenuPrincipal = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnControles = new System.Windows.Forms.Panel();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnNuevoPresupuesto = new System.Windows.Forms.Button();
            this.btnConsultarPresupuestos = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnConsultarProductos = new System.Windows.Forms.Button();
            this.pnUsuario = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.pnMuestra = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.Eliminar = new System.Windows.Forms.Label();
            this.pnMenuPrincipal.SuspendLayout();
            this.pnControles.SuspendLayout();
            this.pnUsuario.SuspendLayout();
            this.pnMuestra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuPrincipal
            // 
            this.pnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnMenuPrincipal.Controls.Add(this.btnSalir);
            this.pnMenuPrincipal.Controls.Add(this.pnControles);
            this.pnMenuPrincipal.Controls.Add(this.pnUsuario);
            this.pnMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnMenuPrincipal.Name = "pnMenuPrincipal";
            this.pnMenuPrincipal.Size = new System.Drawing.Size(170, 540);
            this.pnMenuPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.Location = new System.Drawing.Point(0, 498);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(170, 42);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnControles
            // 
            this.pnControles.Controls.Add(this.btnAcercaDe);
            this.pnControles.Controls.Add(this.button5);
            this.pnControles.Controls.Add(this.button4);
            this.pnControles.Controls.Add(this.btnNuevoPresupuesto);
            this.pnControles.Controls.Add(this.btnConsultarPresupuestos);
            this.pnControles.Controls.Add(this.btnNuevoProducto);
            this.pnControles.Controls.Add(this.btnConsultarProductos);
            this.pnControles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControles.Location = new System.Drawing.Point(0, 170);
            this.pnControles.Name = "pnControles";
            this.pnControles.Size = new System.Drawing.Size(170, 308);
            this.pnControles.TabIndex = 2;
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcercaDe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAcercaDe.FlatAppearance.BorderSize = 0;
            this.btnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcercaDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcercaDe.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAcercaDe.Location = new System.Drawing.Point(0, 252);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(170, 42);
            this.btnAcercaDe.TabIndex = 6;
            this.btnAcercaDe.Text = "Informacion";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(0, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(170, 42);
            this.button5.TabIndex = 5;
            this.button5.Text = ".";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(0, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = ".";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPresupuesto
            // 
            this.btnNuevoPresupuesto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoPresupuesto.FlatAppearance.BorderSize = 0;
            this.btnNuevoPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPresupuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPresupuesto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevoPresupuesto.Location = new System.Drawing.Point(0, 126);
            this.btnNuevoPresupuesto.Name = "btnNuevoPresupuesto";
            this.btnNuevoPresupuesto.Size = new System.Drawing.Size(170, 42);
            this.btnNuevoPresupuesto.TabIndex = 3;
            this.btnNuevoPresupuesto.Text = "Nuevo Presupuesto";
            this.btnNuevoPresupuesto.UseVisualStyleBackColor = true;
            this.btnNuevoPresupuesto.Click += new System.EventHandler(this.btnNuevoPresupuesto_Click);
            // 
            // btnConsultarPresupuestos
            // 
            this.btnConsultarPresupuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarPresupuestos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarPresupuestos.FlatAppearance.BorderSize = 0;
            this.btnConsultarPresupuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarPresupuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPresupuestos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarPresupuestos.Location = new System.Drawing.Point(0, 84);
            this.btnConsultarPresupuestos.Name = "btnConsultarPresupuestos";
            this.btnConsultarPresupuestos.Size = new System.Drawing.Size(170, 42);
            this.btnConsultarPresupuestos.TabIndex = 2;
            this.btnConsultarPresupuestos.Text = "Consultar Presupuestos";
            this.btnConsultarPresupuestos.UseVisualStyleBackColor = true;
            this.btnConsultarPresupuestos.Click += new System.EventHandler(this.btnConsultarPresupuestos_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProducto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevoProducto.Location = new System.Drawing.Point(0, 42);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(170, 42);
            this.btnNuevoProducto.TabIndex = 1;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnConsultarProductos
            // 
            this.btnConsultarProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarProductos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConsultarProductos.FlatAppearance.BorderSize = 0;
            this.btnConsultarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProductos.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConsultarProductos.Location = new System.Drawing.Point(0, 0);
            this.btnConsultarProductos.Name = "btnConsultarProductos";
            this.btnConsultarProductos.Size = new System.Drawing.Size(170, 42);
            this.btnConsultarProductos.TabIndex = 0;
            this.btnConsultarProductos.Text = "Consultar Productos";
            this.btnConsultarProductos.UseVisualStyleBackColor = true;
            this.btnConsultarProductos.Click += new System.EventHandler(this.btnConsultarProductos_Click);
            // 
            // pnUsuario
            // 
            this.pnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnUsuario.Controls.Add(this.lblUsuario);
            this.pnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnUsuario.Name = "pnUsuario";
            this.pnUsuario.Size = new System.Drawing.Size(170, 170);
            this.pnUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblUsuario.Location = new System.Drawing.Point(3, 115);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(164, 52);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMuestra
            // 
            this.pnMuestra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnMuestra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnMuestra.Controls.Add(this.Eliminar);
            this.pnMuestra.Controls.Add(this.pbLogo);
            this.pnMuestra.Location = new System.Drawing.Point(180, 10);
            this.pnMuestra.Name = "pnMuestra";
            this.pnMuestra.Size = new System.Drawing.Size(770, 520);
            this.pnMuestra.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::AutomotrizApp.Properties.Resources.AutomotrizLogo;
            this.pbLogo.Location = new System.Drawing.Point(304, 204);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(162, 112);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSize = true;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Eliminar.Location = new System.Drawing.Point(268, 171);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(234, 20);
            this.Eliminar.TabIndex = 5;
            this.Eliminar.Text = "No se que podriamos poner aca";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.pnMuestra);
            this.Controls.Add(this.pnMenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnMenuPrincipal.ResumeLayout(false);
            this.pnControles.ResumeLayout(false);
            this.pnUsuario.ResumeLayout(false);
            this.pnMuestra.ResumeLayout(false);
            this.pnMuestra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenuPrincipal;
        private System.Windows.Forms.Panel pnMuestra;
        private System.Windows.Forms.Panel pnUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnConsultarProductos;
        private System.Windows.Forms.Panel pnControles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnNuevoPresupuesto;
        private System.Windows.Forms.Button btnConsultarPresupuestos;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Label Eliminar;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}

