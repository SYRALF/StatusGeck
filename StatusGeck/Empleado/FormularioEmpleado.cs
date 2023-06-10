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
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace StatusGeck.Empleado
{
    public partial class FormularioEmpleado : Form
    {
        EmpleadoService empleadoService;
        ErrorProvider errorProvider = new ErrorProvider();  
        public FormularioEmpleado()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            empleadoService = new EmpleadoService(connectionString);
            Consultar();
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
                if(textBoxConfirmar.Text == textBoxContraseña.Text)
                {
                    Entity.Empleado empleado = new Entity.Empleado();

                    empleado.Identificacion = textBoxCedula.Text;
                    empleado.Nombre = textBoxNombre.Text;
                    empleado.Telefono = textBoxTelefono.Text;
                    empleado.Apellido = textBoxApellido.Text;
                    empleado.Direccion = textBoxDireccion.Text;
                    empleado.Correo = textBoxCorreo.Text;
                    empleado.Usuario = textBoxUsuario.Text;
                    empleado.Contraseña = textBoxContraseña.Text;

                    var Mensaje = empleadoService.Guardar(empleado);
                    MessageBox.Show(Mensaje, "Mensaje de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Consultar();
                    limpiar();
                }
                else
                {
                    MessageBox.Show(errorProvider.GetError(textBoxConfirmar), "Mensaje de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                
            }
            else
            {
                MessageBox.Show("Hay campos que faltan", "Mensaje de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
        }
        public bool Validar()
        {
            if(textBoxCedula.Text!="" &&  textBoxNombre.Text!="" &&  textBoxTelefono.Text!="" && textBoxApellido.Text!="" && textBoxCorreo.Text != "" && textBoxDireccion.Text != "" && textBoxUsuario.Text != "" && textBoxContraseña.Text != "" && textBoxConfirmar.Text != "")
            {
                if (textBoxCedula.Text != "Escribir..." && textBoxNombre.Text != "Escribir..." && textBoxTelefono.Text != "Escribir..." && textBoxApellido.Text != "Escribir..." && textBoxCorreo.Text != "Escribir..." && textBoxDireccion.Text != "Escribir..." && textBoxUsuario.Text != "Escribir..." && textBoxContraseña.Text != "Escribir..." && textBoxConfirmar.Text != "Escribir...")
                {
                    return true;

                }
                return false;
            }
            else
            {
               return false;
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
            textBoxUsuario.Text = "Escribir...";
            textBoxContraseña .Text = "Escribir...";
            textBoxConfirmar.Text = "Escribir...";

            textBoxContraseña.UseSystemPasswordChar = false;
            textBoxConfirmar.UseSystemPasswordChar = false;
            btnEditar.Enabled = false;
            textBoxCedula.Enabled = true;

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
        }
        public void Consultar()
        {
            dataGridView2.DataSource = null;
            var respuestaConsulta = empleadoService.ConsultarTodos();
            dataGridView2.DataSource = respuestaConsulta.listempleados;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           TextBox t = e.Control as TextBox;
            if (t != null)
            {
                t.UseSystemPasswordChar = true;
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
                errorProvider.SetError(textBoxApellido, "Falta ingresar apellido");
                textBoxApellido.Text = "Escribir...";
            }
            else
            {
                errorProvider.SetError(textBoxApellido, null);
            }
        }

        private void textBoxApellido_Enter(object sender, EventArgs e)
        {
            if (this.textBoxApellido.Text.Equals("Escribir..."))
            {
                textBoxApellido.Text = "";
            }
        }

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (this.textBoxUsuario.Text.Equals(""))
            {
                errorProvider.SetError(textBoxUsuario, "Falta ingresar Usuario");
                textBoxUsuario.Text = "Escribir...";
            }
            else
            {
                errorProvider.SetError(textBoxUsuario, null);
            }
        }

        private void textBoxUsuario_Enter(object sender, EventArgs e)
        {
            if (this.textBoxUsuario.Text.Equals("Escribir..."))
            {
                textBoxUsuario.Text = "";
            }
        }

        private void textBoxContraseña_Leave(object sender, EventArgs e)
        {
            if (this.textBoxContraseña.Text.Equals(""))
            {
                errorProvider.SetError(textBoxContraseña, "Falta ingresar Contraseña");
                textBoxContraseña.Text = "Escribir...";

                textBoxContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                errorProvider.SetError(textBoxContraseña, null);
            }
        }

        private void textBoxContraseña_Enter(object sender, EventArgs e)
        {
            if (this.textBoxContraseña.Text.Equals("Escribir..."))
            {
                textBoxContraseña.Text = "";

                textBoxContraseña.UseSystemPasswordChar = true;
            }
        }

        private void textBoxConfirmar_Leave(object sender, EventArgs e)
        {
            if (this.textBoxConfirmar.Text.Equals(""))
            {
                errorProvider.SetError(textBoxConfirmar, "Falta ingresar Confirmar");
                textBoxConfirmar.Text = "Escribir...";

                textBoxConfirmar.UseSystemPasswordChar = false;
            }
            else
            {
                errorProvider.SetError(textBoxConfirmar, null);
                ValidadContraseña();
            }
        }

        private void textBoxConfirmar_Enter(object sender, EventArgs e)
        {
            if (this.textBoxConfirmar.Text.Equals("Escribir..."))
            {
                textBoxConfirmar.Text = "";
                textBoxConfirmar.UseSystemPasswordChar = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        public void Editar()
        {
            Entity.Empleado empleado = new Entity.Empleado();

            empleado.Identificacion = textBoxCedula.Text;
            empleado.Nombre = textBoxNombre.Text;
            empleado.Telefono = textBoxTelefono.Text;
            empleado.Apellido = textBoxApellido.Text;
            empleado.Direccion = textBoxDireccion.Text;
            empleado.Correo = textBoxCorreo.Text;
            empleado.Usuario = textBoxUsuario.Text;
            empleado.Contraseña = textBoxContraseña.Text;

            string respuesta = empleadoService.Modificar(empleado);
            MessageBox.Show(respuesta, "Mensaje de Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Consultar();
            limpiar();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionCelda();
        }
        public void SeleccionCelda()
        {
            string indetinficacion = dataGridView2.CurrentRow.Cells[0].Value.ToString();

            Entity.Empleado empleado = new Entity.Empleado();

            var respuesta = empleadoService.BuscarxIdentificacion(indetinficacion);

            empleado = respuesta.empleado;

            textBoxCedula.Text = empleado.Identificacion;
            textBoxApellido.Text = empleado.Apellido;
            textBoxNombre.Text = empleado.Nombre;
            textBoxDireccion.Text = empleado.Direccion;
            textBoxCorreo.Text = empleado.Correo;
            textBoxTelefono.Text = empleado.Telefono;
            textBoxUsuario.Text = empleado.Usuario;
            textBoxContraseña.Text = empleado.Contraseña;
            textBoxConfirmar.Text = "Escribir...";

            textBoxContraseña.UseSystemPasswordChar = true;

            btnEditar.Enabled = true;
            textBoxCedula.Enabled = false;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        public void Eliminar()
        {
            var respuesta = empleadoService.Eliminar(textBoxCedula.Text);
            MessageBox.Show(respuesta, "Mensaje de Eliminacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Consultar();
            limpiar();
        }

        private void textBoxBuscar_Enter(object sender, EventArgs e)
        {
            if (this.textBoxBuscar.Text.Equals("Escribir..."))
            {
                textBoxBuscar.Text = "";
            }
        }

        private void textBoxBuscar_Leave(object sender, EventArgs e)
        {
            if (this.textBoxBuscar.Text.Equals(""))
            {
                textBoxBuscar.Text = "Escribir...";
                Consultar();
            }
        }

        private void textBoxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxBuscar.Text.Trim() != "")
            {
                dataGridView2.DataSource = empleadoService.consultaFiltro(empleadoService.consultarCedula(textBoxBuscar.Text));

            }
            else
            {
                Consultar();
            }
        }

        private void textBoxConfirmar_KeyUp(object sender, KeyEventArgs e)
        {
            ValidadContraseña();
        }
        public void ValidadContraseña()
        {
            if (textBoxConfirmar.Text == textBoxContraseña.Text)
            {

                errorProvider.SetError(textBoxConfirmar, null);
            }
            else
            {
                errorProvider.SetError(textBoxConfirmar, "La contraseña no coinciden");
            }
        }
    }
}
