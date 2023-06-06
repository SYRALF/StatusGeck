using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FacturaRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<Factura> facturas;
        private ClienteRepository clienteRepository;
        private DetalleFacturaRepository detalleFacturaRepository;
        public FacturaRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
            facturas = new List<Factura>();
            
        }
        public void Guardar(Factura factura)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Factura(Codigo,Fecha,Identificacion,CantidadTotal,ValorTotal) 
                                        values (@CodigoFactura,@Fecha,@Identificacion,@CantidadTotal,@ValorTotal)";
                command.Parameters.AddWithValue("@Codigo", factura.Codigo);
                command.Parameters.AddWithValue("@Fecha", factura.Fecha);
                command.Parameters.AddWithValue("@Identificacion", factura.cliente.Identificacion);
                command.Parameters.AddWithValue("@CantidadTotal", factura.CantidadTotal);
                command.Parameters.AddWithValue("@ValorTotal", factura.ValorTotal);
                var filas = command.ExecuteNonQuery();
            }
            foreach(var item in factura.detalleFacturas)
            {

                detalleFacturaRepository.Guardar(item);
            }
        }
        public List<Factura> ConsultarTodos()
        {
            facturas.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Factura";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Factura factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return facturas;
        }
        private Factura DataReaderMapToFactura(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;

            Factura factura = new Factura();
            factura.Codigo = (string)dataReader["Codigo"];
            factura.Fecha = (DateTime)dataReader["Fecha"];
            string identificacion = (string)dataReader["Identificacion"];

            factura.cliente = clienteRepository.BuscarPorIdentificacion(identificacion);


            factura.CantidadTotal = (int)dataReader["CantidadTotal"];
            factura.ValorTotal = (decimal)dataReader["ValorTotal"];

            factura.detalleFacturas = detalleFacturaRepository.ConsultardetalleFactura(factura.Codigo);
            

            return factura;
        }
        public Factura consultarFactura(string codigo)
        {
            Factura factura=null;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Factura where Codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", codigo);
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        factura = DataReaderMapToFactura(dataReader);
                        facturas.Add(factura);
                    }
                }
            }
            return factura;
        }
        public void Eliminar(Factura factura)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from Factura where Codigo=@Codigo";
                command.Parameters.AddWithValue("@Codigo", factura.Codigo);
                command.ExecuteNonQuery();
            }
            detalleFacturaRepository.Eliminar(factura.Codigo);
            
        }
    }
}
