namespace AutomotrizFront.Presentacion.Reportes.Reporte1
{
    partial class FrmReporteVentas
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
            lblTitulo = new Label();
            lblHasta = new Label();
            lblDesde = new Label();
            dtpFechaMin = new DateTimePicker();
            dtpFechaMax = new DateTimePicker();
            btnBuscar = new Button();
            rvReporteVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(15, 15);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(166, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ventas por tipos de autopartes";
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.ForeColor = SystemColors.ControlLight;
            lblHasta.Location = new Point(380, 60);
            lblHasta.Margin = new Padding(4, 0, 4, 0);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(74, 15);
            lblHasta.TabIndex = 1;
            lblHasta.Text = "Fecha Hasta:";
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.ForeColor = SystemColors.ControlLight;
            lblDesde.Location = new Point(15, 60);
            lblDesde.Margin = new Padding(4, 0, 4, 0);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(75, 15);
            lblDesde.TabIndex = 2;
            lblDesde.Text = "Fecha desde:";
            // 
            // dtpFechaMin
            // 
            dtpFechaMin.Location = new Point(106, 53);
            dtpFechaMin.Margin = new Padding(4, 3, 4, 3);
            dtpFechaMin.Name = "dtpFechaMin";
            dtpFechaMin.Size = new Size(233, 23);
            dtpFechaMin.TabIndex = 3;
            // 
            // dtpFechaMax
            // 
            dtpFechaMax.Location = new Point(470, 53);
            dtpFechaMax.Margin = new Padding(4, 3, 4, 3);
            dtpFechaMax.Name = "dtpFechaMax";
            dtpFechaMax.Size = new Size(233, 23);
            dtpFechaMax.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(737, 48);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 27);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // rvReporteVenta
            // 
            rvReporteVenta.BackColor = Color.FromArgb(35, 35, 35);
            rvReporteVenta.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Presentacion.Reportes.Reporte1.RptVenta.rdlc";
            rvReporteVenta.Location = new Point(14, 102);
            rvReporteVenta.Margin = new Padding(4, 3, 4, 3);
            rvReporteVenta.Name = "rvReporteVenta";
            rvReporteVenta.ServerReport.BearerToken = null;
            rvReporteVenta.ShowToolBar = false;
            rvReporteVenta.Size = new Size(870, 484);
            rvReporteVenta.TabIndex = 6;
            // 
            // FrmReporteVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(rvReporteVenta);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFechaMax);
            Controls.Add(dtpFechaMin);
            Controls.Add(lblDesde);
            Controls.Add(lblHasta);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmReporteVentas";
            Text = "FrmReporteVentas";
            Load += FrmReporteVentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaMin;
        private System.Windows.Forms.DateTimePicker dtpFechaMax;
        private System.Windows.Forms.Button btnBuscar;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporteVenta;
    }
}