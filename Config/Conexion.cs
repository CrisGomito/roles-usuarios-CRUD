
using Microsoft.Data.SqlClient;

namespace _CRUD_Semana5.Config
{
    internal class Conexion
    {
        private readonly string cadena_conexion =
            "server=.\\SQLEXPRESS;" +
            "Database=crud_semana5;" +
            "User Id=cris;" +
            "Password=12345;" +
            "Encrypt=True;" +                   // sigue usando cifrado
            "TrustServerCertificate=True;";     // acepta el certificado local
        public SqlConnection getConexion()
        {
            return new SqlConnection(cadena_conexion);
        }
    }
}