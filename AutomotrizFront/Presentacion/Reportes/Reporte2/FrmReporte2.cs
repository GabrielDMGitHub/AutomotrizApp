using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizFront.Presentacion.Reportes.Reporte2
{
    public partial class FrmReporte2 : Form
    {
        public FrmReporte2()
        {
            InitializeComponent();
        }

        private void FrmReporte1_Load(object sender, EventArgs e)
        {
            rvReporte.LocalReport.ReportEmbeddedResource = "AutomotrizFront.Presentacion.Reportes.Reporte2.Reporte2.rdlc";
            rvReporte.RefreshReport();
        }
    }
}
