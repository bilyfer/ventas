using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Modelos;

namespace Ventas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var producto1 = new Producto("Laptop", 20000);
            producto1.AumentarPrecio(20);

            MessageBox.Show(producto1.ObtenerInfo());

            //MessageBox.Show(producto1.Id.ToString());

        }
    }
}
