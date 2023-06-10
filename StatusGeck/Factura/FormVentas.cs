using BLL;
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
    }
}
