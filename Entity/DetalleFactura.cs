using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public Factura factura { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set;}
        public DetalleFactura()
        {
            factura = new Factura();
        }
        public void CalcularSubTotalCompra()
        {
            Subtotal = PrecioVenta * Cantidad;
        }

    }
}
