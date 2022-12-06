using Entidad;
using System.Collections.Generic;

namespace Logica
{
    public class Respuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Propietario> Propietarios { get; set; }
        public List<Animal> Animales { get; set; }
        public Respuesta() { }
        public Respuesta(bool error, string mensaje, List<Propietario> propietarios)
        {
            Error = error;
            Mensaje = mensaje;
            Propietarios = propietarios;
        }

        public Respuesta(bool error, string mensaje, List<Animal> animales) {
            Error = error;
            Mensaje = mensaje;
            Animales = animales;
        }
    }
}
