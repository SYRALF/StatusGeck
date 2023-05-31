using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatusGeck
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Entity.Administrador administrador = new Entity.Administrador();
            Entity.Empleado empleado = new Entity.Empleado();
            Application.Run(new Principal(administrador,empleado));
        }
    }
}
