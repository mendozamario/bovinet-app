using System.Collections.Generic;
using Datos;
using Entidad;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class RepositorioAnimal
    {
        private readonly MySqlConnection _conexion;
        public RepositorioAnimal(ConnectionManager conexion)
        {
            _conexion = conexion._conexion;
        }
        public int Guardar(Animal animal)
        {
            using (var comando = _conexion.CreateCommand())
            {
                comando.CommandText = @"INSERT INTO Animal VALUES (@codigo, @raza, @peso, @estado, @fecha_nacimiento, @tipo, @produccion_promedio, @identificacion)";
                comando.Parameters.Add("codigo", MySqlDbType.VarChar).Value = animal.Codigo;
                comando.Parameters.Add("raza", MySqlDbType.VarChar).Value = animal.Raza;
                comando.Parameters.Add("peso", MySqlDbType.Float).Value = animal.Peso;
                comando.Parameters.Add("fecha_nacimiento", MySqlDbType.Date).Value = animal.FechaNacimiento;
                comando.Parameters.Add("tipo", MySqlDbType.VarChar).Value = animal.Tipo;
                comando.Parameters.Add("produccion_promedio", MySqlDbType.Int64).Value = 0;
                comando.Parameters.Add("estado", MySqlDbType.Int64).Value = animal.Estado;
                comando.Parameters.Add("identificacion", MySqlDbType.VarChar).Value = animal.Propietario.Identificacion;

                var filas = comando.ExecuteNonQuery();
                return filas;
            }
        }
        public List<Animal> Consultar() {
            MySqlDataReader lectorDatos;
            List<Animal> animales = new List<Animal>();
            using (var comando = _conexion.CreateCommand()) {
                comando.CommandText = "SELECT * FROM Animal";
                lectorDatos = comando.ExecuteReader();
                if (lectorDatos.HasRows) {
                    while (lectorDatos.Read()) {
                        Animal animal = Mapear(lectorDatos);
                        animales.Add(animal);
                    }
                }
            }            
            return animales;
        }
        public Animal Mapear(MySqlDataReader lectorDatos)
        {
            if (!lectorDatos.HasRows) return null;
            Animal animal = new Animal() {
                Codigo = lectorDatos.GetString(0),
                Raza = lectorDatos.GetString(1),
                Peso = lectorDatos.GetFloat(2),
                Estado = lectorDatos.GetInt32(3),
                FechaNacimiento = lectorDatos.GetDateTime(4).ToString(),
                Tipo = lectorDatos.GetString(5),
                ProduccionPromedio = lectorDatos.GetInt64(6),
                Propietario = CrearPropietario(lectorDatos.GetString(7))
            };

            return animal;
        }
        public Propietario CrearPropietario(string identificacion) {
            Propietario propietario = new Propietario() {
                Identificacion = identificacion
            };

            return propietario;
        }
    }
}