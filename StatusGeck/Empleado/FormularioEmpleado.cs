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

namespace StatusGeck.Empleado
{
    public partial class FormularioEmpleado : Form
    {
        EmpleadoService empleadoService;
        public FormularioEmpleado()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            empleadoService = new EmpleadoService(connectionString);
            Consultar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
        public void Agregar()
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
            if (this.textBoxNombre.Text.Equals("Escribir..."))
            {
                textBoxNombre.Text = "";
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

        private void textBoxUsuario_Leave(object sender, EventArgs e)
        {
            if (this.textBoxUsuario.Text.Equals(""))
            {
                textBoxUsuario.Text = "Escribir...";
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
                textBoxContraseña.Text = "Escribir...";

                textBoxContraseña.UseSystemPasswordChar = false;
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
                textBoxConfirmar.Text = "Escribir...";

                textBoxConfirmar.UseSystemPasswordChar = false;
            }
            else
            {

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
    }
}
