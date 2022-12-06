using Datos;
using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class RepositorioCredenciales
    {
        private readonly MySqlConnection _conexion;
        public RepositorioCredenciales(ConnectionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public int Guardar(Credenciales credenciales)
        {
            using (var comando = _conexion.CreateCommand()) {
                comando.CommandText = @"INSERT INTO Usuario VALUES (@nombre_usuario, @contraseña, @tipo, @identificacion)";
                comando.Parameters.Add("nombre_usuario", MySqlDbType.VarChar).Value = credenciales.NombreUsuario;
                comando.Parameters.Add("contraseña", MySqlDbType.VarChar).Value = credenciales.Contraseña;
                comando.Parameters.Add("tipo", MySqlDbType.Int64).Value = credenciales.Tipo;
                comando.Parameters.Add("identificacion", MySqlDbType.VarChar).Value = credenciales.Propietario.Identificacion;

                var filas = comando.ExecuteNonQuery();
                return filas;
            } 
        }
    }
}
