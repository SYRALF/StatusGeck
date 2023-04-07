using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Entity;
using BLL;
using System.Configuration;
using static BLL.AdministradorService;
using System.Runtime.InteropServices;

namespace StatusGeck
{
    public partial class FormLogin : Form
    {
        AdministradorService administradorService;
        EmpleadoService empleadoService;
        ErrorProvider errorProvider = new ErrorProvider();
        public FormLogin()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            administradorService = new AdministradorService(connectionString);
            empleadoService = new EmpleadoService(connectionString);
            txtContraseña.UseSystemPasswordChar = true;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
            //Principal frmPrincipal = new Principal();
            //frmPrincipal.Show();
        }
        public void Ingresar()
        {
            string Password = txtContraseña.Text;
            string Usuario = txtUsuario.Text;

            if(Password == "" && Usuario== "")
            {
                errorProvider.SetError(txtUsuario, "Fala ingresar Usuario");
                errorProvider.SetError(txtContraseña, "Fala ingresar Contraseña");
                MessageBox.Show("¡Campos Vacios!", "Mensaje de Ingreso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
            else 
            {
                BusquedaAdministradorRespuesta busquedaAdministrador = new BusquedaAdministradorRespuesta();
                busquedaAdministrador = administradorService.validarLogin(Usuario, Password);

                BusquedaEmpleadoRespuesta busquedaEmpleado = new BusquedaEmpleadoRespuesta();
                busquedaEmpleado = empleadoService.validarLogin(Usuario, Password);

                if( busquedaAdministrador.Administrador != null )
                {
                    MessageBox.Show(busquedaAdministrador.Mensaje, "Mensaje de Ingreso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }else if(busquedaEmpleado.empleado != null)
                {

                }
                else
                {

                }

               

                /*if (!busquedaAdministrador.Error && busquedaAdministrador.Encontro)
                {
                    FormularioPrincipal frmPrincipal = new FormularioPrincipal(busquedaAdministrador.Administrador);
                    frmPrincipal.Show();
                    Hide();
                }*/
            }


        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Ingresar();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Tab))
            {
               
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text.Equals(""))
            {
                errorProvider.SetError(txtUsuario, "Falta ingresar Usuario");
                txtUsuario.Text = "USER";
                txtUsuario.ForeColor = Color.DimGray;
                
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(this.txtUsuario.Text.Equals("USER"))
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (this.txtContraseña.Text.Equals("PASSWORD"))
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (this.txtContraseña.Text.Equals(""))
            {
                txtContraseña.Text = "PASSWORD";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
