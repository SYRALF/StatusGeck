using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmpleadoRepository
    {
        private readonly SqlConnection _connection;
        private readonly List<Empleado> empleados;
        public EmpleadoRepository(ConnectionManager connection)
        {
            _connection = connection._conexion;
            empleados = new List<Empleado>();
        }
        public void Guardar(Empleado empleado)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"Insert Into Empleado(Identificacion,Nombre,Apellido,Telefono,Direccion,Correo,Usuario,Contraseña) 
                                        values (@Identificacion,@Nombre,@Apellido,@Telefono,@Direccion,@Correo,@Usuario,@Contraseña)";
                command.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                command.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                command.Parameters.AddWithValue("@Correo", empleado.Correo);
                command.Parameters.AddWithValue("@Usuario", empleado.Usuario);
                command.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);
                var filas = command.ExecuteNonQuery();
            }
        }
        public List<Empleado> ConsultarTodos()
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
        public Empleado BuscarPorIdentificacion(string identificacion)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Empleado where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", identificacion);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToEmpleado(dataReader);
            }
        }
        public void Eliminar(Empleado emplado)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Delete from Empleado where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", emplado.Identificacion);
                command.ExecuteNonQuery();
            }
        }
        public void Modificar(Empleado empleado)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"update Empleado set Nombre=@Nombre,Apellido=@Apellido,
                                        Telefono=@Telefono,Direccion=@Direccion,
                                        Correo=@Correo, Usuario=@Usuario, Contraseña=@Contraseña where Identificacion=@Identificacion";
                command.Parameters.AddWithValue("@Identificacion", empleado.Identificacion);
                command.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                command.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                command.Parameters.AddWithValue("@Telefono", empleado.Telefono);
                command.Parameters.AddWithValue("@Direccion", empleado.Direccion);
                command.Parameters.AddWithValue("@Correo", empleado.Correo);
                command.Parameters.AddWithValue("@Usuario", empleado.Usuario);
                command.Parameters.AddWithValue("@Contraseña", empleado.Contraseña);
                var filas = command.ExecuteNonQuery();
            }
        }
        public Empleado Buscar(string usuario, string contraseña)
        {
            SqlDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Empleado where Usuario=@Usuario and Contraseña=@Contraseña";
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                return DataReaderMapToEmpleado(dataReader);
            }
        }
        public List<Empleado> consultarCedula(string letra)
        {
            List<Empleado> listaempleados = empleados;
            listaempleados = listaempleados.Where(L => L.Identificacion.Contains(letra)).ToList();
            return listaempleados;
        }
    }

}
