using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public  class DetalleFacturaRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<DetalleFactura> detalleFacturas;
        public DetalleFacturaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
            detalleFacturas = new List<DetalleFactura>();
        }
        public void Guardar(DetalleFactura detalleFactura)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into DetalleFactura(CodigoFactura,Descripcion,Cantidad,PrecioVenta,Subtotal) 
                                        values (@CodigoFactura,@Descripcion,@Cantidad,@PrecioVenta,@Subtotal)";
                command.Parameters.AddWithValue("@CodigoFactura", detalleFactura.codigofactura);
                command.Parameters.AddWithValue("@Descripcion", detalleFactura.Descripcion);
                command.Parameters.AddWithValue("@Cantidad", detalleFactura.Cantidad);
                command.Parameters.AddWithValue("@PrecioVenta", detalleFactura.PrecioVenta);
                command.Parameters.AddWithValue("@Subtotal", detalleFactura.Subtotal);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<DetalleFactura> ConsultardetalleFactura(string codigofactura)
        {
            detalleFacturas.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from DetalleFactura where CodigoFactura=@CodigoFactura";
                command.Parameters.AddWithValue("@Identificacion", codigofactura);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        DetalleFactura detalleFactura = DataReaderMapToEmpleado(dataReader);
                        detalleFacturas.Add(detalleFactura);
                    }
                }
            }
            return detalleFacturas;
        }
        private DetalleFactura DataReaderMapToEmpleado(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;

            DetalleFactura detalleFactura = new DetalleFactura();
            detalleFactura.codigofactura = (string)dataReader["CodigoFactura"];
            detalleFactura.Descripcion = (string)dataReader["Descripcion"];
            detalleFactura.Cantidad = (int)dataReader["Cantidad"];
            detalleFactura.PrecioVenta = (decimal)dataReader["PrecioVenta"];
            detalleFactura.Subtotal = (decimal)dataReader["Subtotal"];

            return detalleFactura;
        }
        public void Eliminar(string codigofactura)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from DetalleFactura where CodigoFactura=@CodigoFactura";
                command.Parameters.AddWithValue("@CodigoFactura", codigofactura);
                command.ExecuteNonQuery();
            }
        }
    }
}
