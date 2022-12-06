using MySql.Data.MySqlClient;

namespace Datos
{
    public class ConnectionManager
    {
        internal MySqlConnection _conexion;
        public ConnectionManager(string connectionString)
        {
            _conexion= new MySqlConnection(connectionString);
        }

        public void Open()
        {
            _conexion.Open();
        }
        public void Close() {
            _conexion.Close();   
        }
    }
}
