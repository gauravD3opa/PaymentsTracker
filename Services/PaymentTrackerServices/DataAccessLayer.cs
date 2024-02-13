using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTrackerServices
{
    public class DataAccessLayer
    {
            public void ExecuteGetAllUsersProcedure()
            {
                using (SqlConnection connection = new SqlConnection(DBConnection.SQLConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("X_PRC_GET_ALL_USERS", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
    }
    
}
