using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Test03052022Michailidis
{
    class SQLRepository
    {
        private string connString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = FakturaDB; Integrated Security = True; Connect Timeout = 30;" +
            " Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public List<Faktura> Getfaktury()
        {
            List<Faktura> faktury = new List<Faktura>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "select  * from faktura";
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            using ()
                        }
                            
                    }
                }    
            }
            
        }
                
            
        
       }
}
