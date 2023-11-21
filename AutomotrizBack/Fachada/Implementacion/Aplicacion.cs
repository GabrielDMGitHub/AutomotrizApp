using AutomotrizBack.Datos.Implementacion;
using AutomotrizBack.Datos.Interfaz;
using AutomotrizBack.Entidades;
using AutomotrizBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizBack.Fachada.Implementacion
{
    public class Aplicacion : IAplicacion
    {
        private IPresupuestoDao dao;
        private ILogin login;
        private IProducto prod;
        public Aplicacion()
        {
            dao = new PresupuestoDao();
            login = new Login();
            prod = new ProductoDao();
        }
        public List<Producto> GetProductos()
        {
            return dao.ObtenerProductos();
        }

        public bool GuadarPresupuesto(Presupuesto presupuesto)
        {
            return dao.CrearPresupuesto(presupuesto);
        }

        bool IAplicacion.Cliente(Cliente cliente)
        {
            return dao.Cliente(cliente);
        }

        List<Cliente> IAplicacion.GetClientes()
        {
            return dao.ObtenerCliente();
        }

        void IAplicacion.InsertarProducto(Producto producto)
        {
            prod.InsertarProducto(producto);
        }

        void IAplicacion.ActualizarProducto(Producto producto)
        {
            prod.ActualizarProducto(producto);
        }

        bool IAplicacion.EliminarProducto(Producto producto)
        {
            return prod.EliminarProducto(producto);
        }

        bool IAplicacion.Logeado(Cliente c)
        {
            return login.Logeado(c);
        }
    }
}
