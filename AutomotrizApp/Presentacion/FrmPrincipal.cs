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
using AutomotrizApp.Entidades;

namespace AutomotrizApp
{
    public partial class FrmPrincipal : Form
    {
        // Instancias de Formularios y atributos
        // ================================================================================================================================= //
        FrmLogin Login = new FrmLogin();
        FrmConsultarProductos ConsultarProductos = new FrmConsultarProductos();

        public static Cliente clienteActivo;
        // ================================================================================================================================= //

        public FrmPrincipal()
        {
            Login.ShowDialog();
            InitializeComponent();

            lblUsuario.Text = clienteActivo.NombreCompleto.ToString();
        }

        //Metodos
        // ================================================================================================================================= //
        //Carga los formularios en el panel principal
        private void CambiarFormulario(Form Formulario)
        {
            pnMuestra.Controls.Clear();

            Formulario.TopLevel = false;
            pnMuestra.Controls.Add(Formulario);
            Formulario.Dock = DockStyle.Fill;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Show();
        }

        //Eventos
        // ================================================================================================================================= //
        //Cierra el programa completo
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //Botones del menu
        private void btnConsultarProductos_Click(object sender, EventArgs e)
        {
            CambiarFormulario(ConsultarProductos);
        }
    }
}
