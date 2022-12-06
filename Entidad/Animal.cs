using System;
using System.Collections.Generic;

namespace Entidad
{
    public class Animal
    {
        public string Codigo { get; set; }
        public string Raza { get; set; }
        public float Peso { get; set; }
        public int Estado { get; set; }
        public string FechaNacimiento { get; set; }
        public string Tipo { get; set; }
        public double ProduccionPromedio { get; set; }
        public Propietario Propietario { get; set; }
        public List<Produccion> Producciones { get; set; }
        public void CalcularPromedioProducido()
        {
            int sumaProducido = 0;
            foreach (var producto in Producciones)
            {
                sumaProducido = sumaProducido + producto.Cantidad;
            }
            ProduccionPromedio = sumaProducido / (Producciones.Count + 1);
        }
    }
}