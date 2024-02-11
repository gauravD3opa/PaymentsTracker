using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace PaymentsTrackerServicesHost
{
    public class Program
    {
           public static int Main()
           {
                using (ServiceHost host = new ServiceHost(typeof(PaymentTrackerServices.UserService.UserService)))
                {
                    host.Open();
                    Console.WriteLine("User Service Started at " + DateTime.Now);
                    Console.ReadLine();
                }
                return 0;
           }
    }
}
