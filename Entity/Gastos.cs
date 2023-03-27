using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Gastos
    {
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set;}
        public decimal PrecionUnitario { get; set; }
        public decimal Total { get; set; }

        public void CalcularTotal()
        {
            Total = Cantidad * PrecionUnitario;
        }
    }
}
