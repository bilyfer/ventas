using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;
using Ventas.Modelos;

namespace Ventas
{
    public partial class Menu : Form
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        ClientesBL _clientesBL;
        CiudadBL _ciudadBL;
        FacturaBL _facturaBL;

        public Menu()
        {
            InitializeComponent();

            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
            _clientesBL = new ClientesBL();
            _ciudadBL = new CiudadBL();
            _facturaBL = new FacturaBL();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new Form1();
            formProductos.MdiParent = this;

            formProductos.cargarDatos(_productosBL, _categoriasBL);

            formProductos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new Form2();
            formClientes.MdiParent = this;

            formClientes.cargarDatos(_clientesBL, _ciudadBL);

            formClientes.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new Form3();
            formFactura.MdiParent = this;

            formFactura.cargarDatos(_facturaBL, _clientesBL, _productosBL);

            formFactura.Show();
        }
    }
}
