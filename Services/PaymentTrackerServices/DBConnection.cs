using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PaymentTrackerServices
{
    public class DBConnection
    {

        private static string SQLDatabaseConnectionString;

        public static string SQLConnectionString
        {
            get
            {
                SQLDatabaseConnectionString = Convert.ToString(ConfigurationManager.ConnectionStrings["PaymentsTrackerDBConnection"].ConnectionString);
                return SQLDatabaseConnectionString;
            }
        }

    }

}
