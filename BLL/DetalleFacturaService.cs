using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleFacturaService
    {
        private readonly ConnectionManager conexion;
        private readonly DetalleFacturaRepository repositorio;
        Administrador administrador;
        public DetalleFacturaService(string connectionString, Administrador administrador)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DetalleFacturaRepository(conexion);
            this.administrador = administrador;
        }
        public DetalleFacturaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DetalleFacturaRepository(conexion);
        }
        public string Guardar(DetalleFactura detalleFactura)
        {
            //Email email = new Email(administrador);
            string mensajeEmail = string.Empty;
            try
            {
                conexion.Open();
                repositorio.Guardar(detalleFactura);
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
        public string Eliminar(string codigofactura)
        {
            try
            {
                conexion.Open();
               
                    repositorio.Eliminar(codigofactura);
                    conexion.Close();
                    return ($"El registro  se ha eliminado satisfactoriamente.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public List<DetalleFactura> ConsultarTodos(string CodigoFactura)
        {
            try
            {
                conexion.Open();
                return  repositorio.ConsultardetalleFactura(CodigoFactura);
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conexion.Close();

            }
        }
    }
}
