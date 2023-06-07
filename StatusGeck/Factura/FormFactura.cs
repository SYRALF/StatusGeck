using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace StatusGeck.Factura
{
    public partial class FormFactura : Form
    {
        ClienteService clienteService;
        FacturaService facturaService;
        
        public FormFactura()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            clienteService = new ClienteService(connectionString);
            facturaService = new FacturaService(connectionString);
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            BuscarCLiente();
        }
        public void BuscarCLiente()
        {
            var respuesta = clienteService.BuscarxIdentificacion(textBoxCedula.Text);
            if(respuesta.cliente != null)
            {

                textBoxNombre.Text = respuesta.cliente.Nombre;
            }
            else
            {

                MessageBox.Show(respuesta.Mensaje, "Mensaje de Busqueda", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

        }
    }

}
