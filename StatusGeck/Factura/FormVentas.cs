using BLL;
using Entity;
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

namespace StatusGeck.Factura
{
    public partial class FormVentas : Form
    {
        FacturaService facturaService;
        public FormVentas()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            facturaService = new FacturaService(connectionString);
            CalcularVentas();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GestionFiltroFechas(false);
        }
        public void GestionFiltroFechas(bool tipo)
        {
            dateTimePicker1.Enabled = tipo;
            dateTimePicker2.Enabled = tipo;
            btnConsultar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        public void Consultar()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            textBoxpreciototal.Text = "0";
            if (radioButton1.Checked == true)
            {
                var respuesta = facturaService.ConsultarTodos();

                MessageBox.Show(respuesta.Mensaje, "Mensaje de Busqueda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                PintarTAblaFactura(respuesta.facturas);
            }
            else
            {
                var respuesta = facturaService.ConsultarxFecha(dateTimePicker1.Value, dateTimePicker2.Value);
                if (respuesta.facturas == null)
                {

                }
                else if(respuesta.facturas.Count >0)
                {
                    PintarTAblaFactura(respuesta.facturas);

                }
                MessageBox.Show(respuesta.Mensaje, "Mensaje de Busqueda", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }


        }
        public void PintarTAblaFactura(List<Entity.Factura> facturas)
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = facturaService.ConsultaFacturas(facturas);

            textBoxpreciototal.Text = facturaService.CalcularTotalFacturas(facturas).ToString();
            
        }
        public void PintarTAblaDetalles(List<Entity.DetalleFactura> detalleFacturas)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = detalleFacturas;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GestionFiltroFechas(true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            var respuesta = facturaService.BuscarxCodigo(codigo);

            PintarTAblaDetalles(respuesta.Factura.detalleFacturas);
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {

        }

        private void textBoxGasto_Enter(object sender, EventArgs e)
        {
            if (this.textBoxGasto.Text.Equals("Escribir..."))
            {
                textBoxGasto.Text = "";
            }
        }

        private void textBoxGasto_Leave(object sender, EventArgs e)
        {
            if (this.textBoxGasto.Text.Equals(""))
            {
                textBoxGasto.Text = "Escribir...";
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularGanancias();
        }
        public void CalcularGanancias()
        {
            textboxganancias.Text = (Convert.ToDecimal(textBoxVentas.Text) - Convert.ToDecimal(textBoxGasto.Text)).ToString();
        }

        private void dateTimePicker3_Leave(object sender, EventArgs e)
        {
            CalcularVentas();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            CalcularVentas();
        }

        public void CalcularVentas()
        {
            var respuesta = facturaService.ConsultarxFecha(dateTimePicker3.Value, dateTimePicker3.Value);
            textBoxVentas.Text = facturaService.CalcularTotalFacturas(respuesta.facturas).ToString();
        }
    }
}
