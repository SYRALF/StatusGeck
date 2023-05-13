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
            Agregar();
        }
        public void Agregar()
        {
            Entity.Cliente cliente = new Entity.Cliente();

            cliente.Identificacion = textBoxCedula.Text;
            cliente.Nombre = textBoxNombre.Text;
            cliente.Telefono = textBoxTelefono.Text;
            cliente.Apellido = textBoxApellido.Text;
            cliente.Direccion = textBoxDireccion.Text;
            cliente.Correo = textBoxCorreo.Text;

            var Mensaje = clienteService.Guardar(cliente);
            MessageBox.Show(Mensaje, "Mensaje de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Consultar();
            limpiar();
        }
        public void limpiar()
        {
            textBoxCedula.Text = "Escribir...";
            textBoxNombre.Text = "Escribir...";
            textBoxTelefono.Text = "Escribir...";
            textBoxApellido.Text = "Escribir...";
            textBoxDireccion.Text = "Escribir...";
            textBoxCorreo.Text = "Escribir...";
            
            
        }
        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        public void Consultar()
        {
            dataGridView1.DataSource = null;
            var respuestaConsulta = clienteService.ConsultarTodos();
            dataGridView1.DataSource = respuestaConsulta.clientes;
        }



        #region Validacion de diseño
        private void textBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBuscar.Text.Trim() != "")
            {
                dataGridView1.DataSource = clienteService.consultarCedula(textBuscar.Text);

            }
            else
            {
                Consultar();
            }
        }

        private void textBuscar_Leave(object sender, EventArgs e)
        {
            if (this.textBuscar.Text.Equals(""))
            {
                textBuscar.Text = "Escribir...";
                Consultar();
            }
        }

        private void textBuscar_Enter(object sender, EventArgs e)
        {
            if (this.textBuscar.Text.Equals("Escribir..."))
            {
                textBuscar.Text = "";
            }
        }

        private void textBoxCedula_Leave(object sender, EventArgs e)
        {
            if (this.textBoxCedula.Text.Equals(""))
            {
                textBuscar.Text = "Escribir...";
            }
        }

        private void textBoxCedula_Enter(object sender, EventArgs e)
        {
            if (this.textBoxCedula.Text.Equals("Escribir..."))
            {
                textBoxCedula.Text = "";
            }
        }

        private void textBoxNombre_Leave(object sender, EventArgs e)
        {
            if (this.textBoxNombre.Text.Equals(""))
            {
                textBoxNombre.Text = "Escribir...";
            }
        }

        private void textBoxNombre_Enter(object sender, EventArgs e)
        {
            if (this.textBoxNombre.Text.Equals("Escribir..."))
            {
                textBoxNombre.Text = "";
            }
        }

        private void textBoxCorreo_Leave(object sender, EventArgs e)
        {
            if (this.textBoxCorreo.Text.Equals(""))
            {
                textBoxCorreo.Text = "Escribir...";
            }
        }

        private void textBoxCorreo_Enter(object sender, EventArgs e)
        {
            if (this.textBoxCorreo.Text.Equals("Escribir..."))
            {
                textBoxCorreo.Text = "";
            }
        }

        private void textBoxTelefono_Leave(object sender, EventArgs e)
        {
            if (this.textBoxTelefono.Text.Equals(""))
            {
                textBoxTelefono.Text = "Escribir...";
            }
        }

        private void textBoxTelefono_Enter(object sender, EventArgs e)
        {
            if (this.textBoxTelefono.Text.Equals("Escribir..."))
            {
                textBoxTelefono.Text = "";
            }
        }

        private void textBoxDireccion_Leave(object sender, EventArgs e)
        {
            if (this.textBoxDireccion.Text.Equals(""))
            {
                textBoxDireccion.Text = "Escribir...";
            }
        }

        private void textBoxDireccion_Enter(object sender, EventArgs e)
        {
            if (this.textBoxDireccion.Text.Equals("Escribir..."))
            {
                textBoxDireccion.Text = "";
            }
        }

        private void textBoxApellido_Leave(object sender, EventArgs e)
        {
            if (this.textBoxApellido.Text.Equals(""))
            {
                textBoxApellido.Text = "Escribir...";
            }
        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {
            if (this.textBoxApellido.Text.Equals("Escribir..."))
            {
                textBoxApellido.Text = "";
            }
        }
        #endregion

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public void Eliminar()
        {
            var respuesta = clienteService.Eliminar(textBoxCedula.Text);
            MessageBox.Show(respuesta, "Mensaje de Eliminacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Consultar();
            limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var datos = dataGridView1.DataSource;
            int posicion = dataGridView1.CurrentRow.Index;

        }
    }
}
