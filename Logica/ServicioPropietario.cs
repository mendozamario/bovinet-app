using Datos;
using Entidad;
using System;

namespace Logica
{
    public class ServicioPropietario
    {
        private readonly ConnectionManager conexion;
        private readonly RepositorioPropietario repositorio;

        public ServicioPropietario(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new RepositorioPropietario(conexion);
        }
        public string Guardar(Propietario propietario)
        {
            try
            {
                conexion.Open();
                repositorio.Guardar(propietario);
                return "Guardado exitosamente";
            }
            catch (Exception e)
            {
                return $"Error de Aplicación {e.Message}";
                throw;
            }
        }
        public Respuesta Consultar()
        {
            Respuesta respuesta = new Respuesta();
            try
            {
                conexion.Open();
                respuesta.Propietarios = repositorio.Consultar();
                conexion.Close();
                respuesta.Error = false;
                if (respuesta.Propietarios.Count > 0)
                {
                    respuesta.Mensaje = "Consulta Realizada";
                }else
                {
                    respuesta.Mensaje = "Base de Datos Vacia";
                }
                return respuesta;
            }
            catch (Exception e) 
            { 
                respuesta.Error = true;
                respuesta.Mensaje = $"Error de Aplicación {e.Message}";
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
