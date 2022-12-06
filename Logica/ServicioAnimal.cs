using Logica;
using Entidad;
using Datos;
using System;

namespace Logica
{
    public class ServicioAnimal
    {
        private readonly ConnectionManager conexion;
        private readonly RepositorioAnimal repositorio;

        public ServicioAnimal(string connectionString) {
            conexion =  new ConnectionManager(connectionString);
            repositorio = new RepositorioAnimal(conexion);
        }

        public string Guardar(Animal animal) {
            try
            {
                conexion.Open();
                repositorio.Guardar(animal);
                return "Guardado Exitosamente";
            }
            catch (Exception e)
            {
                return $"Error de Aplicación {e.Message}";
            }
        }

        public Respuesta Consultar() {
            Respuesta respuesta = new Respuesta();
            try
            {
                conexion.Open();
                respuesta.Animales = repositorio.Consultar();
                conexion.Close();
                respuesta.Error = false;
                if (respuesta.Animales.Count > 0)
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