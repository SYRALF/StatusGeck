using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public string Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public int CantidadTotal { get; set; }
        public List<DetalleFactura> detalleFacturas { get; set; }
        public Factura()
        {
            detalleFacturas = new List<DetalleFactura>();
        }
        public void AgregarDetalle(string descripcion, int cantidad, decimal precioventa)
        {
            DetalleFactura detalleFactura = new DetalleFactura();
            detalleFactura.codigofactura = Codigo;
            detalleFactura.Descripcion = descripcion;
            detalleFactura.Cantidad = cantidad;
            detalleFactura.PrecioVenta = precioventa; ;

            detalleFactura.CalcularSubTotalCompra();
            
            detalleFacturas.Add(detalleFactura);
        }
        public void CalcularValorTotal()
        {
            ValorTotal = detalleFacturas.Sum(df => df.Subtotal);
        }
        public void CalcularCantidadTotal()
        {
            CantidadTotal = detalleFacturas.Count();
        }
        public int calcularcantidaditems()
        {
            return detalleFacturas.Sum(df => df.Cantidad);
        }
        public List<DetalleFactura> ObtenerDetalles()
        {
            return detalleFacturas;
        }
        public void EditarDetalle(string descripcion, int cantidad, decimal precioventa, int posicion)
        {
            List<DetalleFactura> detalleFacturaAux = detalleFacturas;
            int cont = 0;
            foreach (var item in detalleFacturaAux)
            {
                if (cont == posicion)
                {
                    AgregarDetalle(descripcion, cantidad, precioventa);
                }
                else
                {
                    AgregarDetalle(item.Descripcion,item.Cantidad,item.PrecioVenta);
                }
                EliminarDEtalle(cont);

                cont++;
            }
        }
        public void EliminarDEtalle(int posicion)
        {
            detalleFacturas.RemoveAt(posicion);
        }
    }
}
