namespace Entidad
{
    public class Credenciales
    {
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public int Tipo { get; set; }
        public Propietario Propietario { get; set; }
    }
}
