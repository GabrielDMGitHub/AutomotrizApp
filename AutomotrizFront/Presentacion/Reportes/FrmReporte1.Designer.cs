namespace AutomotrizFront.Reportes
{
    partial class FrmReporte1
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
            rvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // rvReporte
            // 
            rvReporte.BackColor = Color.FromArgb(35, 35, 35);
            rvReporte.Location = new Point(10, 10);
            rvReporte.Name = "ReportViewer";
            rvReporte.ServerReport.BearerToken = null;
            rvReporte.ShowToolBar = false;
            rvReporte.Size = new Size(878, 580);
            rvReporte.TabIndex = 0;
            // 
            // FrmReporte1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 43, 43);
            ClientSize = new Size(898, 600);
            Controls.Add(rvReporte);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmReporte1";
            Text = "FrmReporte1";
            Load += FrmReporte1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvReporte;
    }
}