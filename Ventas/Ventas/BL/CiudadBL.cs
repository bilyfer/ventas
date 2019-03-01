using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class CiudadBL
    {
        public BindingList<Ciudad> ListadeCiudades { get; set; }

        public CiudadBL()
        {
            ListadeCiudades = new BindingList<Ciudad>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");

            ListadeCiudades.Add(ciudad1);
            ListadeCiudades.Add(ciudad2);
        }
    }
}
