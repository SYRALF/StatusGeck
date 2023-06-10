using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using Entity;
using StatusGeck.Factura;
using StatusGeck.Cliente;
using StatusGeck.Empleado;
using System.Runtime.CompilerServices;

namespace StatusGeck
{
    public partial class Principal : Form
    {
        //campos
        private IconButton botonActual;
        private Panel leftBordenBtn;
        private Form formularioActual;
        

        public Principal(Administrador administrador,Entity.Empleado empleado)
        {
            InitializeComponent();
            if(administrador != null)
            {
                btnEmpleado.Visible = true;
            }
            leftBordenBtn = new Panel();
            leftBordenBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBordenBtn);
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        //metodos
        private void ActivarBoton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DesactivarBoton();
                //boton
                botonActual = (IconButton)senderBtn;
                botonActual.BackColor = Color.FromArgb(37,36,81);
                botonActual.ForeColor = color;
                botonActual.TextAlign = ContentAlignment.MiddleCenter;
                botonActual.IconColor = color;
                botonActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                botonActual.ImageAlign = ContentAlignment.MiddleRight;

                //boton izquierdo
                leftBordenBtn.BackColor = color;
                leftBordenBtn.Location = new Point(0, botonActual.Location.Y);
                leftBordenBtn.Visible = true;
                leftBordenBtn.BringToFront();

                //boton titulo
                iconoFormulario.IconChar = botonActual.IconChar;
                iconoFormulario.IconColor = color;
                titulo.Text = botonActual.Text;
            }
        }
        //colores
        private struct Colour
        {
            public static Color color1 = Color.FromArgb(255,255,102);
            public static Color color2 = Color.FromArgb(0,255,255);
            public static Color color3 = Color.FromArgb(0,255,128);
            public static Color color4 = Color.FromArgb(0,255,0);
            public static Color color5 = Color.FromArgb(128,255,0);
        }
        private void DesactivarBoton()
        {
            if(botonActual != null)
            {
                botonActual.BackColor = Color.FromArgb(0, 0, 64);
                botonActual.ForeColor = Color.Gainsboro;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.Gainsboro;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //abrir formulario hijo

        private void AbrirFormularioHijo(Form childForm)
        {
            if(formularioActual != null)
            {
                formularioActual.Close();
            }
            formularioActual = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pFormularios.Controls.Add(childForm);
            pFormularios.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //metodos del formulario
        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color1);
            AbrirFormularioHijo(new FormCliente());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color2);
            AbrirFormularioHijo(new FormularioEmpleado());
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color3);
            AbrirFormularioHijo(new FormFactura());
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color4);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color5);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            formularioActual.Close();
            Reset();
        }

        private void Reset()
        {
            DesactivarBoton();
            leftBordenBtn.Visible = false;
            iconoFormulario.IconChar = IconChar.House;
            iconoFormulario.IconColor = Color.DeepPink;
            titulo.Text = "Home";
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
