using AutomotrizApp.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizApp.Presentacion
{
    public partial class FrmNuevoProducto : Form
    {
        public FrmNuevoProducto()
        {
            InitializeComponent();

            LimpiarControles();
            DBHelper.ObtenerInstancia().CargarCombo(cboTipoProducto, "SP_Consultar_Tipos");
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, null, "SP_Consultar_Productos");
        }



        //Metodos
        // ================================================================================================================================= //
        //Limpia el contenido de los controles (txt, cbo y dgv)
        private void LimpiarControles()
        {
            txtNombreProducto.Text = "";
            txtPrecioProducto.Text = "";
            cboTipoProducto.Items.Clear();
            dgvConsultarProductos.Rows.Clear();
        }
        // ================================================================================================================================= //



        //Metodos
        // ================================================================================================================================= //
        //
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
        // ================================================================================================================================= //
    }
}
