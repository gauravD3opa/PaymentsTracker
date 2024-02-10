using System.ServiceModel;
using (ServiceHost host= new ServiceHost(typeof(PaymentsTrackerServices.UserService.UserService)))
{
    host.Open();
    Console.WriteLine("User Service started at" + DateTime.Now);
    Console.ReadLine();
}
