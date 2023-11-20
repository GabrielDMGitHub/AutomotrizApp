namespace AutomotrizFront.Presentacion.Reportes.Reporte3
{
    partial class FrmReporte3
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
            pnReporte = new Panel();
            rvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            lblTitulo = new Label();
            pnReporte.SuspendLayout();
            SuspendLayout();
            // 
            // pnReporte
            // 
            pnReporte.AutoScroll = true;
            pnReporte.AutoSize = true;
            pnReporte.Controls.Add(rvReporte);
            pnReporte.Location = new Point(12, 144);
            pnReporte.Name = "pnReporte";
            pnReporte.Size = new Size(874, 444);
            pnReporte.TabIndex = 7;
            // 
            // rvReporte
            // 
            rvReporte.BackColor = Color.FromArgb(35, 35, 35);
            rvReporte.Dock = DockStyle.Fill;
            rvReporte.Location = new Point(0, 0);
            rvReporte.Name = "ReportViewer";
            rvReporte.ServerReport.BearerToken = null;
            rvReporte.ShowToolBar = false;
            rvReporte.Size = new Size(874, 444);
            rvReporte.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ControlLight;
            lblTitulo.Location = new Point(13, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(485, 37);
            lblTitulo.TabIndex = 8;
            lblTitulo.Text = "Ventas por tipos de autopartes";
            // 
            // FrmReporte3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(lblTitulo);
            Controls.Add(pnReporte);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporte3";
            Text = "FrmReporte3";
            Load += FrmReporte3_Load;
            pnReporte.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnReporte;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporte;
        private Label lblTitulo;
    }
}