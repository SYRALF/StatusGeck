using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdministradorService
    {
        private readonly ConnectionManager conexion;
        private readonly AdministradorRepository repositorio;
        public AdministradorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new AdministradorRepository(conexion);
        }
        public BusquedaAdministradorRespuesta validarLogin(string usuario, string contraseña)
        {
            BusquedaAdministradorRespuesta respuesta = new BusquedaAdministradorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Administrador = repositorio.Buscar(usuario, contraseña);
                conexion.Close();
                respuesta.Encontro = (respuesta.Administrador != null) ? true : false;
                respuesta.Mensaje = (respuesta.Administrador != null) ? "Datos Correctos" : "Usuario y/o contraseña incorrecta";
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
        public class BusquedaAdministradorRespuesta
        {
            public bool Encontro { get; set; }
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Administrador Administrador { get; set; }
        }
    }
}
