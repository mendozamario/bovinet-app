using Datos;
using Logica;
using Entidad;
using System;

namespace Logica
{
    public class ServicioCredenciales
    {
        private readonly ConnectionManager conexion;
        private readonly RepositorioCredenciales repositorio;

        public ServicioCredenciales(string connectionString) {
            conexion = new ConnectionManager(connectionString);
            repositorio = new RepositorioCredenciales(conexion);
        }

        public string Guardar(Credenciales credenciales) {
            try {
                conexion.Open();
                repositorio.Guardar(credenciales);
                return "Guardado Exitosamente";
            } catch (Exception e) {
                return $"Error de la Aplicación {e.Message}";
            }
        }
    }
}
