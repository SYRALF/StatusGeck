using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class AdministradorRepository
    {
        private readonly SqlConnection _connection;
        public AdministradorRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
        }

        public Administrador Buscar(string usuario, string contraseña)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Administrador where Usuario=@Usuario and Contraseña=@Contraseña";
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToPerson(dataReader);
            }
        }
        private Administrador DataReaderMapToPerson(SqlDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Administrador administrador = new Administrador();
            administrador.Identificacion = (string)dataReader["Identificacion"];
            administrador.Usuario = (string)dataReader["Usuario"];
            administrador.Contraseña = (string)dataReader["Contraseña"];
            return administrador;
        }
    }
}
