using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reporte
    {
        public string Codigo { get; set; }
        public DateTime FechaInicial { get; set; }
        public DateTime FechaFinal { get; set; }
        public List<Contabilidad> listacontabilidad { get; set; }
        public decimal Total { get; set; }

        public void CalcularGanancia()
        {

        }

    }
}
