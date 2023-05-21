using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BLL.AdministradorService;

namespace BLL
{
    public class EmpleadoService
    {
        private readonly ConnectionManager conexion;
        private readonly EmpleadoRepository repositorio;
        Administrador administrador;
        public EmpleadoService(string connectionString, Administrador administrador)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new EmpleadoRepository(conexion);
            this.administrador = administrador;
        }
        public EmpleadoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new EmpleadoRepository(conexion);
        }
        public string Guardar(Empleado empleado)
        {
            //Email email = new Email(administrador);
            string mensajeEmail = string.Empty;
            try
            {
                conexion.Open();
                repositorio.Guardar(empleado);
                //mensajeEmail = email.EnviarEmail(persona);
                conexion.Close();
                return $"Se guardaron los datos satisfactoriamente: {mensajeEmail}";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaEmpleadoRespuesta validarLogin(string usuario, string contraseña)
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            try
            {

                conexion.Open();
                respuesta.empleado = repositorio.Buscar(usuario, contraseña);
                conexion.Close();
                //respuesta.Encontro = (respuesta.empleado != null) ? true : false;
                respuesta.Mensaje = (respuesta.empleado != null) ? "Datos Correctos" : "Usuario y/o contraseña incorrecta";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConsultaRespuestaEmpleado ConsultarTodos()
        {
            ConsultaRespuestaEmpleado consulta = new ConsultaRespuestaEmpleado();
            try
            {
                conexion.Open();
                consulta = new ConsultaRespuestaEmpleado(repositorio.ConsultarTodos());
                consulta.Mensaje = "Se consultó correctamente";
                return consulta;
            }
            catch (Exception e)
            {
                consulta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                consulta.listempleados = null;
                return consulta;
            }
            finally
            {
                conexion.Close();

            }
        }
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var empleado = repositorio.BuscarPorIdentificacion(identificacion);
                if (empleado != null)
                {
                    repositorio.Eliminar(empleado);
                    conexion.Close();
                    return ($"El registro {empleado.Nombre} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Empleado empleadoNuevo)
        {
            try
            {
                conexion.Open();
                var empleadoViejo = repositorio.BuscarPorIdentificacion(empleadoNuevo.Identificacion);
                if (empleadoViejo != null)
                {
                    repositorio.Modificar(empleadoNuevo);
                    return ($"El registro de {empleadoNuevo.Nombre} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, El cliente con Identificación {empleadoNuevo.Identificacion} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaEmpleadoRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaEmpleadoRespuesta respuesta = new BusquedaEmpleadoRespuesta();
            try
            {
                conexion.Open();
                respuesta.empleado = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.empleado != null) ? "Se encontró el cliente buscado" : "El cliente buscado no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
       

    }
    public class BusquedaEmpleadoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Empleado empleado { get; set; }
    }
    public class ConsultaRespuestaEmpleado
    {
        public string Mensaje { get; set; }
        public List<Persona> listempleados;

        public ConsultaRespuestaEmpleado(List<Empleado> empleados)
        {
            listempleados = new List<Persona>();
            foreach (Empleado e in empleados)
            {
                Persona persona = new Persona();
                persona.Identificacion = e.Identificacion;
                persona.Nombre = e.Nombre;
                persona.Telefono = e.Telefono;
                persona.Apellido = e.Apellido;
                persona.Direccion = e.Direccion;
                persona.Correo = e.Correo;
                listempleados.Add(persona);
            }
        }
        public ConsultaRespuestaEmpleado()
        {

        }
    }
    

    
}
