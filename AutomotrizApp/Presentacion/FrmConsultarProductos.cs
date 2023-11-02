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
    public partial class FrmConsultarProductos : Form
    {
        public FrmConsultarProductos()
        {
            InitializeComponent();

            LimpiarControles();
            DBHelper.ObtenerInstancia().CargarCombo(cboTipoProducto, "SP_Consultar_Tipos");
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, null, "SP_Consultar_Productos");
            //txtNombreProducto.AutoCompleteSource = ---> Completar mas adelante
        }

        //Metodos
        // ================================================================================================================================= //
        //Limpia el contenido de los controles (txt, cbo y dgv)
        private void LimpiarControles()
        {
            txtNombreProducto.Text = "";
            txtPrecioProductoMin.Text = "";
            txtPrecioProductoMax.Text = "";
            cboTipoProducto.Items.Clear();
            dgvConsultarProductos.Rows.Clear();
        }
        // ================================================================================================================================= //



        //Eventos
        // ================================================================================================================================= //
        //Carga y filtra el contenido del dgv
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<Parametro> lista = new List<Parametro>();

            if (txtNombreProducto.Text != "")
            {
                lista.Add(new Parametro("@input_nombre", txtNombreProducto.Text));
            }
            if (txtPrecioProductoMin.Text != "")
            {
                lista.Add(new Parametro("@input_precio_min", txtNombreProducto.Text));
            }
            if (txtPrecioProductoMax.Text != "")
            {
                lista.Add(new Parametro("@input_precio_max", txtNombreProducto.Text));
            }
            if (cboTipoProducto.SelectedItem != null)
            {
                lista.Add(new Parametro("@input_tipo", cboTipoProducto.SelectedValue));
            }

            dgvConsultarProductos.Rows.Clear();
            DBHelper.ObtenerInstancia().CargarGrilla(dgvConsultarProductos, lista, @"SP_Consultar_Productos");
        }

        private void FrmConsultarProductos_Load(object sender, EventArgs e)
        {

        }
        // ================================================================================================================================= //
    }
}
