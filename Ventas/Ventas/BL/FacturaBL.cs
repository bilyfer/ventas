using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Modelos;

namespace Ventas.BL
{
    public class FacturaBL
    {
        public BindingList<Factura> ListadeFacuras { get; set; }
        public int NumeroFactura { get; set; }

        public FacturaBL()
        {
            ListadeFacuras = new BindingList<Factura>();
            NumeroFactura = 1;
        }

        public void NuevaFactura()
        {
            var nuevaFactura = new Factura();
            nuevaFactura.Id = NumeroFactura;

            ListadeFacuras.Add(nuevaFactura);
            NumeroFactura += 1;
        }
    }
}
