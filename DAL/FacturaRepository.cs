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
        }
        public List<Factura> ConsultarTodos()
        {
            empleados.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Empleado";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Empleado empleado = DataReaderMapToEmpleado(dataReader);
                        empleados.Add(empleado);
                    }
                }
            }
            return empleados;
        }
        private Empleado DataReaderMapToEmpleado(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;

            Empleado empleado = new Empleado();
            empleado.Identificacion = (string)dataReader["Identificacion"];
            empleado.Nombre = (string)dataReader["Nombre"];
            empleado.Apellido = (string)dataReader["Apellido"];
            empleado.Telefono = (string)dataReader["Telefono"];
            empleado.Direccion = (string)dataReader["Direccion"];
            empleado.Correo = (string)dataReader["Correo"];
            empleado.Usuario = (string)dataReader["Usuario"];
            empleado.Contraseña = (string)dataReader["Contraseña"];

            return empleado;
        }
    }
}
