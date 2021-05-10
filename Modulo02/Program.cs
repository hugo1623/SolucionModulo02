using System;
using System.Configuration;
using System.Data.SqlClient;
//using System.Data.SqlClient;

namespace Modulo02
{
    class Program
    {

        static void Main(string[] args)
        {
            /*var mensaje = ConfigurationManager.AppSettings["mensaje"];
              Console.WriteLine(mensaje);*/

            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-H4CI0FL";
            builder.InitialCatalog = "Prueba";
            builder.IntegratedSecurity = false;
            builder.UserID = "sa";
            builder.Password = "Luis";

            var connectionString = builder.ToString();

            using(SqlConnection sql= new SqlConnection(connectionString))
            {
                sql.Open();
            }
            Console.ReadLine();
        }
    }
  
}
