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
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace StatusGeck.Cliente
{
    public partial class FormCliente : Form
    {
        ClienteService clienteService;
        ErrorProvider errorProvider = new ErrorProvider();
        public FormCliente()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            clienteService = new ClienteService(connectionString);
            ValidarTamañoMximo();
        }
        public void ValidarTamañoMximo()
        {
            textBoxCedula.MaxLength = 10;
            textBoxNombre.MaxLength = 15;
            textBoxTelefono.MaxLength = 10;
            textBoxApellido.MaxLength = 15;
            textBoxDireccion.MaxLength = 30;
            textBoxCorreo.MaxLength = 30;
        }
        public void ValidarTamañominimo(TextBox textBox, int tamañominimo)
        {
            if(textBox.Text.Length >= tamañominimo)
            {
                errorProvider.SetError(textBox, null);
            }
            else
            {
                errorProvider.SetError(textBox, $"Minimo {tamañominimo} caracter(es)");
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void msgError(string msg)
        {
            lblError.Text = "     " + msg;
            lblError.Visible = true;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        public void Agregar()
        {
            if (Validar())
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
            else
            {
                MessageBox.Show("Hay campos que no cumplen requisitos", "Mensaje de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
           
        }
        public bool Validar()
        {
            if (errorProvider.GetError(textBoxCedula) != "" || errorProvider.GetError(textBoxNombre) != "" || errorProvider.GetError(textBoxTelefono) != "" || errorProvider.GetError(textBoxApellido) != "" || errorProvider.GetError(textBoxCorreo) != "" || errorProvider.GetError(textBoxDireccion) != "")
            {
                    return false;
            }
            else
            {
                return true;
            }
        }

        public void limpiar()
        {
            textBoxCedula.Text = "Escribir...";
            textBoxNombre.Text = "Escribir...";
            textBoxTelefono.Text = "Escribir...";
            textBoxApellido.Text = "Escribir...";
            textBoxDireccion.Text = "Escribir...";
            textBoxCorreo.Text = "Escribir...";
            btnEditar.Enabled = false;
            textBoxCedula.Enabled = true;

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
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
                errorProvider.SetError(textBoxCedula, "Falta ingresar Cedula");

                textBoxCedula.Text = "Escribir...";
            }
            else
            {
                errorProvider.SetError(textBoxCedula, null);
                ValidarTamañominimo(textBoxCedula, 6);
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
                errorProvider.SetError(textBoxNombre, "Falta ingresar Nombre");
                textBoxNombre.Text = "Escribir...";
            }
            else
            {
                errorProvider.SetError(textBoxNombre, null);

                ValidarTamañominimo(textBoxNombre, 1);
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
                errorProvider.SetError(textBoxCorreo, "Falta ingresar Correo");

                textBoxCorreo.Text = "Escribir...";
            }
            else
            {
                errorProvider.SetError(textBoxCorreo, null);

                ValidarTamañominimo(textBoxCorreo, 17);
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
                errorProvider.SetError(textBoxTelefono, "Falta ingresar Telefono");

                textBoxTelefono.Text = "Escribir...";
            }
            else
            {
                errorProvider.SetError(textBoxTelefono, null);
                ValidarTamañominimo(textBoxTelefono, 10);
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
                errorProvider.SetError(textBoxDireccion, "Falta ingresar Direccion");

                textBoxDireccion.Text = "Escribir...";
            }
            else
            {
                errorProvider.SetError(textBoxDireccion, null);
                ValidarTamañominimo(textBoxDireccion, 10);
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
            else
            {
                errorProvider.SetError(textBoxApellido, null);
                ValidarTamañominimo(textBoxApellido, 4);

            }
        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {
            if (this.textBoxApellido.Text.Equals("Escribir..."))
            {
                errorProvider.SetError(textBoxApellido, "Falta ingresar apellido");

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
            string indetinficacion = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            Entity.Cliente cliente = new Entity.Cliente();

            var respuesta = clienteService.BuscarxIdentificacion(indetinficacion);

            cliente = respuesta.cliente;

            textBoxCedula.Text = cliente.Identificacion;
            textBoxApellido.Text = cliente.Nombre;
            textBoxNombre.Text = cliente.Nombre;
            textBoxDireccion.Text = cliente.Direccion;
            textBoxCorreo.Text = cliente.Correo;
            textBoxTelefono.Text = cliente.Telefono;

            btnEditar.Enabled = true;
            textBoxCedula.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        public void Editar()
        {
            Entity.Cliente cliente = new Entity.Cliente();

            cliente.Identificacion = textBoxCedula.Text;
            cliente.Nombre = textBoxNombre.Text;
            cliente.Telefono = textBoxTelefono.Text;
            cliente.Apellido = textBoxApellido.Text;
            cliente.Direccion = textBoxDireccion.Text;
            cliente.Correo = textBoxCorreo.Text;

            string respuesta = clienteService.Modificar(cliente);
            MessageBox.Show(respuesta, "Mensaje de Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Consultar();
            limpiar();
        }

        private void lineShape5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCedula_KeyUp(object sender, KeyEventArgs e)
        {
                ValidarTamañominimo(textBoxCedula, 6);
        }

        private void textBoxNombre_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarTamañominimo(textBoxNombre, 1);
        }

        private void textBoxCorreo_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarTamañominimo(textBoxCorreo, 17);
        }

        private void textBoxTelefono_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarTamañominimo(textBoxTelefono, 10);
        }

        private void textBoxDireccion_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarTamañominimo(textBoxDireccion, 10);
        }

        private void textBoxApellido_KeyUp(object sender, KeyEventArgs e)
        {
            ValidarTamañominimo(textBoxApellido, 4);
        }
    }
}
