﻿namespace Entidad
{
    public class Propietario
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public Credenciales Credenciales { get; set; }
    }
}
