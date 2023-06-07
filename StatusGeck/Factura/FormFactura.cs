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
        public void Limpiar()
        {
            textBoxCedula.Text = "Escribir...";
            textBoxNombre.Text = "";
            textBoxCodigo.Text = "Escribir....";
            textBoxcantidadtotal.Text = "0";
            textBoxpreciototal.Text = "0";
            limpiardetalles();
            btnEliminar.Enabled = false;
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
        public void AgregarDetalles()
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

        private void textBoxCedula_Leave(object sender, EventArgs e)
        {
            if (this.textBoxCedula.Text.Equals(""))
            {
                textBoxCedula.Text = "Escribir...";
            }
        }

        private void textBoxCedula_Enter(object sender, EventArgs e)
        {
            if (this.textBoxCedula.Text.Equals("Escribir..."))
            {
                textBoxCedula.Text = "";
            }
        }

        private void textBoxDescripcion_Leave(object sender, EventArgs e)
        {
            if (this.textBoxDescripcion.Text.Equals(""))
            {
                textBoxCedula.Text = "Escribir...";
            }
        }

        private void textBoxDescripcion_Enter(object sender, EventArgs e)
        {
            if (this.textBoxDescripcion.Text.Equals("Escribir..."))
            {
                textBoxDescripcion.Text = "";
            }
        }

        private void textBoxCantidad_Leave(object sender, EventArgs e)
        {
            if (this.textBoxCantidad.Text.Equals(""))
            {
                textBoxCantidad.Text = "Escribir...";
            }
        }

        private void textBoxCantidad_Enter(object sender, EventArgs e)
        {
            if (this.textBoxCantidad.Text.Equals("Escribir..."))
            {
                textBoxCantidad.Text = "";
            }
        }

        private void textBoxPrecio_Leave(object sender, EventArgs e)
        {
            if (this.textBoxPrecio.Text.Equals(""))
            {
                textBoxPrecio.Text = "Escribir...";
            }
        }

        private void textBoxPrecio_Enter(object sender, EventArgs e)
        {
            if (this.textBoxPrecio.Text.Equals("Escribir..."))
            {
                textBoxPrecio.Text = "";
            }
        }

        private void textBoxCodigo_Enter(object sender, EventArgs e)
        {
            if (this.textBoxCodigo.Text.Equals("Escribir..."))
            {
                textBoxCodigo.Text = "";
            }
        }

        private void textBoxCodigo_Leave(object sender, EventArgs e)
        {
            if (this.textBoxCodigo.Text.Equals(""))
            {
                textBoxCodigo.Text = "Escribir...";
            }
        }


        private void textBoxpreciototal_Leave(object sender, EventArgs e)
        {

        }

        private void textBoxpreciototal_Enter(object sender, EventArgs e)
        {

        }

        private void btnlimpiardetalles_Click(object sender, EventArgs e)
        {
            limpiardetalles();
        }
        public void limpiardetalles()
        {
            textBoxDescripcion.Text = "Escribir...";
            textBoxCantidad.Text = "Escribir...";
            textBoxPrecio.Text = "Escribir...";
        }
    }

}
