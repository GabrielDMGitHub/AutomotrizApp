using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion.Reportes.Reporte3
{
    public partial class FrmReporte3 : Form
    {
        public FrmReporte3()
        {
            InitializeComponent();
        }

        private void FrmReporte3_Load(object sender, EventArgs e)
        {
            rvReporte.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Presentacion.Reportes.Reporte3.Reporte3.rdlc";
            rvReporte.RefreshReport();
        }
    }
}
