﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.BL;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void cargarDatos(ProductosBL productosBL, CategoriasBL categoriasBL)
        {
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;
        }
    }
}
