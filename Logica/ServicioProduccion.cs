using Datos;
using Logica;
using Entidad;
using System;

namespace Logica
{
    public class ServicioProduccion
    {
        private readonly ConnectionManager conexion;
        private readonly RepositorioProduccion repositorio;
        public ServicioProduccion(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new RepositorioProduccion(conexion);
        }
        public string Guardar(Produccion produccion)
        {
            try {
                conexion.Open();
                repositorio.Guardar(produccion);
                return "Guardado exitosamente";
            } catch (Exception e) {
                return $"Error de Aplicación {e.Message}";
            }
        }
    }
}
