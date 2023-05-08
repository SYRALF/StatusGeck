using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using System.Configuration;

namespace StatusGeck.Cliente
{
    public partial class FormCliente : Form
    {
        ClienteService clienteService;
        public FormCliente()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            clienteService = new ClienteService(connectionString);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        public void Agregar()
        {
            
        }
    }
}
