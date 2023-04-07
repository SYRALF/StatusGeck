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

namespace StatusGeck
{
    public partial class Principal : Form
    {
        //campos
        private IconButton botonActual;
        private Panel leftBordenBtn;

        public Principal()
        {
            InitializeComponent();
            leftBordenBtn = new Panel();
            leftBordenBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBordenBtn);
        }
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
                botonActual.BackColor = Color.Orchid;
                botonActual.ForeColor = Color.LightGray;
                botonActual.TextAlign = ContentAlignment.MiddleLeft;
                botonActual.IconColor = Color.LightGray;
                botonActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color1);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color2);
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color3);
        }

        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color4);
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colour.color5);
        }
    }
}
