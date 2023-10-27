using AutomotrizApp.Presentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp
{
    public partial class FrmPrincipal : Form
    {
        // Instancia de Formularios
        FrmLogin Login = new FrmLogin();

        public FrmPrincipal()
        {
            Login.ShowDialog();
            InitializeComponent();
        }
    }
}
