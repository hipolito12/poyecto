using System.Data;
using System.Data.SqlClient;

namespace Datos2
{
    public class conexioncs
    {
        private SqlConnection Conexion = new SqlConnection("Data Source=localhost;Initial Catalog=tp2;Integrated Security=false");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
