using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
    public  class FacturaService
    {
        private readonly ConnectionManager conexion;
        private readonly FacturaRepository repositorio;
        Administrador administrador;
        public FacturaService(string connectionString, Administrador administrador)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new FacturaRepository(conexion);
            this.administrador = administrador;
        }
        public FacturaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new FacturaRepository(conexion);
        }
        public string Guardar(Factura factura)
        {
            //Email email = new Email(administrador);
            string mensajeEmail = string.Empty;
            try
            {
                conexion.Open();
                if (repositorio.consultarFactura(factura.Codigo) == null)
                {
                    repositorio.Guardar(factura);
                    //mensajeEmail = email.EnviarEmail(persona);
                    conexion.Close();
                    return $"Se guardaron los datos satisfactoriamente {mensajeEmail}";
                }
                else
                {
                    conexion.Close();
                    return $"Este Codigo de factura Ya existe {mensajeEmail}";
                }

            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public ConsultaRespuestaFactura ConsultarTodos()
        {
            ConsultaRespuestaFactura consulta = new ConsultaRespuestaFactura();
            try
            {
                conexion.Open();
                consulta.facturas = repositorio.ConsultarTodos();
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
        public BusquedaRespuestaFActura BuscarxCodigo(string codigo)
        {
            BusquedaRespuestaFActura respuesta = new BusquedaRespuestaFActura();
            try
            {
                conexion.Open();
                respuesta.Factura = repositorio.consultarFactura(codigo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Factura != null) ? "Se encontró el codigo de la factura buscada" : "No se encontró el codigo de la factura buscada";
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
        public string Eliminar(string codigo)
        {
            try
            {
                conexion.Open();
                var factura = repositorio.consultarFactura(codigo);
                if (factura != null)
                {
                    repositorio.Eliminar(factura);
                    conexion.Close();
                    return ($"El registro {factura.cliente.Nombre} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, la factura con codigo de {factura.Codigo} no se encuentra registrada.");
            }
            catch (Exception e)
            {
                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }
        }
        public List<FacturaAuxiliar> ConsultaFacturas(List<Factura> facturas)
        {
            List<FacturaAuxiliar> facturaAuxiliars = new List<FacturaAuxiliar>();
            foreach(var item in facturas)
            {
                FacturaAuxiliar facturaAuxiliar = new FacturaAuxiliar(item.Codigo, item.Fecha, item.cliente.Identificacion, item.CantidadTotal, item.ValorTotal);
                facturaAuxiliars.Add(facturaAuxiliar);
            }
            return facturaAuxiliars;
        }
        public ConsultaRespuestaFactura ConsultarxFecha(DateTime fechainicia, DateTime fechafinal)
        {
            ConsultaRespuestaFactura consulta = new ConsultaRespuestaFactura();
            try
            {
                if( fechainicia.Date > fechafinal.Date)
                {
                    consulta.facturas = null;
                    consulta.Mensaje = "La fecha inicial no debe ser mayor a la fecha final";
                }
                else
                {
                    conexion.Open();
                    consulta.facturas = repositorio.ConsultarxFecha(fechainicia,fechafinal);

                    consulta.Mensaje = (consulta.facturas.Count != 0) ? "Se consulto Correctamen" : "No hay Facturas Que mostrar";
                    
                }
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

        public class ConsultaRespuestaFactura
        {
            public List<Factura> facturas { get; set; }
            public string Mensaje { get; set; }
        }
        public class BusquedaRespuestaFActura
        {
            public Factura Factura { get; set;}
            public string Mensaje { get; set; }
            public bool Error { get; set; }

        }
        public class FacturaAuxiliar
        {
            public string Codigo { get; set; }
            public DateTime Fecha { get; set; }
            public string Identificacion { get; set; }
            public int CantidadTotal { get; set; }
            public decimal ValorTotal { get; set; }

            public FacturaAuxiliar(string codigo, DateTime fecha, string identificacion, int cantidad, decimal valortotal)
            {
                Codigo = codigo;
                Fecha = fecha;
                Identificacion = identificacion;
                CantidadTotal = cantidad; 
                ValorTotal = valortotal;
            }
        }
    }
}
