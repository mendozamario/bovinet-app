using Datos;
using Entidad;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioPropietario
    {
        private readonly MySqlConnection _conexion;

        public RepositorioPropietario(ConnectionManager conexion)
        {
            _conexion = conexion._conexion;
        }

        public int Guardar(Propietario propietario)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = @"INSERT INTO Propietario VALUES (@identificacion, @nombre, @correo, @telefono, @direccion)";
                comando.Parameters.Add("identificacion", MySqlDbType.VarChar).Value = propietario.Identificacion;
                comando.Parameters.Add("nombre", MySqlDbType.VarChar).Value = propietario.Nombre;
                comando.Parameters.Add("correo", MySqlDbType.VarChar).Value = propietario.Correo;
                comando.Parameters.Add("telefono", MySqlDbType.VarChar).Value = propietario.Telefono;
                comando.Parameters.Add("direccion", MySqlDbType.VarChar).Value = propietario.Direccion;

                var filas = comando.ExecuteNonQuery();
                return filas;
            }
        }
        public List<Propietario> Consultar()
        {
            MySqlDataReader lectorDatos;
            List<Propietario> propietarios = new List<Propietario>();
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = "SELECT * FROM Propietario";
                lectorDatos = comando.ExecuteReader();
                if (lectorDatos.HasRows)
                {
                    while (lectorDatos.Read())
                    {
                        Propietario propietario = Mapear(lectorDatos);
                        propietarios.Add(propietario);
                    }
                }
            }
            return propietarios;
        }
        public Propietario Mapear(MySqlDataReader lectorDatos)
        {
            if (!lectorDatos.HasRows) return null;
            Propietario propietario = new Propietario
            {
                Identificacion = lectorDatos.GetString(0),
                Nombre = lectorDatos.GetString(1),
                Correo = lectorDatos.GetString(2),
                Telefono = lectorDatos.GetString(3),
                Direccion = lectorDatos.GetString(4),
            };
            return propietario;
        }
    }
}
