using System;
using System.Collections.Generic;
using System.Text;
//using Microsoft.Data.SqlClient;
//using System.Data.SqlTypes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace datos

{
    public class Class1
    {
        static void Main(string[] args)
        {
            try
            {
               /* SqlConnectionStringBuilder bui = new SqlConnectionStringBuilder
                {

                    DataSource = "DESKTOP-NSKK8Q3",
                    UserID= "",
                    InitialCatalog = "tp2",
                    PersistSecurityInfo = false
                };*/

                using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=tp2;Integrated Security=true"))
                {
                    Console.WriteLine("empieza la conexion");
                    string query = "SELECT  * FROM materias";
                    using (SqlCommand cmd = new SqlCommand(query,connection))
                    {
                        
                        connection.Open();
                       
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                          
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1} {2} {3} {4}", reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetInt32(4));

                            }
                        }
                    }
                }


            }
            catch (Exception e) { Console.WriteLine(e); }
            
        }
    }
}
