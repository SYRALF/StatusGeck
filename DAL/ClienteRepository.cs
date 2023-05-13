using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ClienteRepository
    {
        private readonly SqlConnection _connection;
        public List<Cliente> clientes;
        public ClienteRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
            clientes = new List<Cliente>();
        }
        public void Guardar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Cliente(Identificacion,Nombre,Apellido,Telefono,Direccion,Correo) 
                                        values (@Identificacion,@Nombre,@Apellido,@Telefono,@Direccion,@Correo)";
                command.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Cliente> ConsultarTodos()
        {
            clientes.Clear();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Cliente";
                var dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = DataReaderMapToPerson(dataReader);
                        clientes.Add(cliente);
                    }
                }
            }
            return clientes;
        }
        private Cliente DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
             
            Cliente cliente = new Cliente();
            cliente.Identificacion = (string)dataReader["Identificacion"];
            cliente.Nombre = (string)dataReader["Nombre"];
            cliente.Apellido = (string)dataReader["Apellido"];
            cliente.Telefono = (string)dataReader["Telefono"];
            cliente.Direccion = (string)dataReader["Direccion"];
            cliente.Correo = (string)dataReader["Correo"];

            return cliente;
        }

        public Cliente BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Cliente where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToPerson(dataReader);
            }
        }
        public void Eliminar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from Cliente where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                command.ExecuteNonQuery();
            }
        }
        public void Modificar(Cliente cliente)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update Cliente set Nombre=@Nombre,Apellido=@Apellido,
                                        Telefono=@Telefono,Direccion=@Direccion,
                                        Correo=@Correo where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", cliente.Identificacion);
                command.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", cliente.Apellido);
                command.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                command.Parameters.AddWithValue("@Direccion", cliente.Direccion);
                command.Parameters.AddWithValue("@Correo", cliente.Correo);
                var filas = command.ExecuteNonQuery();
            }
        }

        public List<Cliente> consultarCedula(string letra)
        {
            List<Cliente> listacliente = clientes;
            listacliente = clientes.Where(L => L.Identificacion.Contains(letra)).ToList();
            return listacliente;
        }
    }
}

