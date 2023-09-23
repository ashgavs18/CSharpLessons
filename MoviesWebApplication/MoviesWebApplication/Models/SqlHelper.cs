using Microsoft.Data.SqlClient;

namespace MoviesWebApplication.Models
{
    public class SqlHelper
    {
       
        
            public static SqlConnection CreateConnection()
            {
                var connString = @"server=200411LTP2780\SQLEXPRESS;database = testdb;integrated security = true;Encrypt = false;";
                SqlConnection sqlcn = new SqlConnection(connString);
                return sqlcn;
            }

        //200411LTP2780\SQLEXPRESS
    }
}
