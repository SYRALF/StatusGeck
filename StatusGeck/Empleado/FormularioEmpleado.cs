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
            textBoxContraseña.UseSystemPasswordChar = true;
            textBoxConfirmar.UseSystemPasswordChar = true;
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            empleadoService = new EmpleadoService(connectionString);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

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
            btnEditar.Enabled = false;
            textBoxCedula.Enabled = true;

            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
        }
        public void Consultar()
        {
            dataGridView2.DataSource = null;
            var respuestaConsulta = empleadoService.ConsultarTodos();
            dataGridView2.DataSource = respuestaConsulta.empleados;
            dataGridView2.Columns[7].DefaultCellStyle.Format = "*";

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
    }
}
