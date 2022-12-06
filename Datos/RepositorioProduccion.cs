using System;
using Datos;
using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class RepositorioProduccion
    {
        private readonly MySqlConnection _conexion;
        public RepositorioProduccion(ConnectionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public int Guardar(Produccion produccion)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = @"INSERT INTO Produccion VALUES (@fecha, @cantidad, @costo_dia, @codigo)";
                comando.Parameters.Add("fecha", MySqlDbType.Date).Value = produccion.Fehca;
                comando.Parameters.Add("cantidad", MySqlDbType.Int64).Value = produccion.Cantidad;
                comando.Parameters.Add("costo_dia", MySqlDbType.Float).Value = produccion.CostoDia;
                comando.Parameters.Add("codigo", MySqlDbType.VarChar).Value = produccion.Animal.Codigo;

                var filas = comando.ExecuteNonQuery();
                return filas;
                
            }

        }
    }
}
