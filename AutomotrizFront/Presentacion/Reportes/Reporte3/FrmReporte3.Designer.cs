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
            rvReporte3 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // rvReporte3
            // 
            rvReporte3.BackColor = Color.FromArgb(35, 35, 35);
            rvReporte3.Location = new Point(10, 10);
            rvReporte3.Name = "ReportViewer";
            rvReporte3.ServerReport.BearerToken = null;
            rvReporte3.ShowToolBar = false;
            rvReporte3.Size = new Size(878, 580);
            rvReporte3.TabIndex = 0;
            // 
            // FrmReporte3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(rvReporte3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporte3";
            Text = "FrmReporte3";
            Load += FrmReporte3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReporte3;
    }
}