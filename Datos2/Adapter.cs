using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Datos2
{
    public class Adapter
    {
        public SqlConnection sqlConn = Adapter.Conexion();
         
        private static SqlConnection Conexion()
        {
            //return new SqlConnection();
            return  new SqlConnection(ConfigurationManager.ConnectionStrings["entities"].ConnectionString.ToString() );
        }

        protected void OpenConnection()
        {
            if (sqlConn == null)
                sqlConn = Adapter.Conexion();
            sqlConn.Open();
        }

        protected void CloseConnection()
        {
            sqlConn.Close();
            sqlConn = null;
        }





    }

}

