using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetalleFactura
    {
        public string codigofactura { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Subtotal { get; set;}
        public DetalleFactura()
        {
            
        }
        public void CalcularSubTotalCompra()
        {
            Subtotal = PrecioVenta * Cantidad;
        }

    }
}
