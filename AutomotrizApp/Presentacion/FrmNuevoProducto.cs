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
        private int idNuevoProducto;
        public FrmNuevoProducto(int idProducto = 0)
        {
            InitializeComponent();

            LimpiarControles();
            DBHelper.ObtenerInstancia().CargarCombo(cboTipoProducto, "SP_CONSULTAR_TIPOS");
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, null, "SP_CONSULTAR_PRODUCTOS");

            if (idProducto != 0)
            {
                idNuevoProducto = idProducto;
                lblTitulo.Text = "Editar Presupuesto";
            }
            else
            {
                idNuevoProducto = 99;
                lblTitulo.Text = "Nuevo Presupuesto";
                // ---> Consultar proximo id para producto y asignarlo a idNuevoProducto
            }
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
        //Load
        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            lblTitulo.Text += " (N" + idNuevoProducto + ")";
        }


        //
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        
        // ================================================================================================================================= //
    }
}
