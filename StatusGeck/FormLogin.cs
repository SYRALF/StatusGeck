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
using Entity;
using BLL;
using System.Configuration;
using static BLL.AdministradorService;

namespace StatusGeck
{
    public partial class FormLogin : Form
    {
        AdministradorService administradorService;
        ErrorProvider errorProvider = new ErrorProvider();
        public FormLogin()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            administradorService = new AdministradorService(connectionString);
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        public void Ingresar()
        {
            BusquedaAdministradorRespuesta busquedaAdministrador = new BusquedaAdministradorRespuesta();

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
                busquedaAdministrador = administradorService.validarLogin(Usuario, Password);

                MessageBox.Show(busquedaAdministrador.Mensaje, "Mensaje de Ingreso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

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
                errorProvider.SetError(txtUsuario, "Fala ingresar Usuario");
            }
        }
    }
}
