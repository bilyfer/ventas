using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class ClientesBL
    {
        public BindingList<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new BindingList<Cliente>();
            CrearDatosdePrueba();
        }

        private void CrearDatosdePrueba()
        {
            var ciudad1 = new Ciudad(1, "San Pedro Sula");
            var ciudad2 = new Ciudad(2, "Tegucigalpa");

            var cliente1 = new Cliente(1, "Juan Perez", "99558877", "SPS", ciudad1);
            var cliente2 = new Cliente(2, "Maria Martinez", "88557744", "Tegus", ciudad2);

            ListadeClientes.Add(cliente1);
            ListadeClientes.Add(cliente2);
        }
    }
}
