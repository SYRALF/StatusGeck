using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        Administrador administrador;
        public ClienteService(string connectionString, Administrador administrador)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
            this.administrador = administrador;
        }
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
        }
        public string Guardar(Cliente cliente)
        {
            //Email email = new Email(administrador);
            string mensajeEmail = string.Empty;
            try
            {
                conexion.Open();
                repositorio.Guardar(cliente);
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
        public ConsultaRespuesta ConsultarTodos()
        {
            ConsultaRespuesta consulta = new ConsultaRespuesta();
            try
            {
                conexion.Open();
                consulta.clientes = repositorio.ConsultarTodos();
                consulta.Mensaje = "Se consultó correctamente";
                return consulta;
            }
            catch (Exception e)
            {
                consulta.Mensaje = $"Error de la Aplicacion: {e.Message}";
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
                var cliente = repositorio.BuscarPorIdentificacion(identificacion);
                if (cliente != null)
                {
                    repositorio.Eliminar(cliente);
                    conexion.Close();
                    return ($"El registro {cliente.Nombre} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public string Modificar(Cliente clienteNuevo)
        {
            try
            {
                conexion.Open();
                var clienteviejo = repositorio.BuscarPorIdentificacion(clienteNuevo.Identificacion);
                if (clienteviejo != null)
                {
                    repositorio.Modificar(clienteNuevo);
                    return ($"El registro de {clienteNuevo.Nombre} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, El cliente con Identificación {clienteNuevo.Identificacion} no se encuentra registrado.");
                }
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public BusquedaClienteRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            try
            {
                conexion.Open();
                respuesta.cliente = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.cliente != null) ? "Se encontró el cliente buscado" : "El cliente buscado no existe";
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
    public class BusquedaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente cliente { get; set; }
    }
    public class ConsultaRespuesta
    {
        public string Mensaje { get; set; }
        public List<Cliente> clientes;
    }
}
