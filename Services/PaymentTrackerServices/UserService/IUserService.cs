using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PaymentTrackerServices.UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        bool IsAlive();

        [OperationContract]
         List<User> GetAllUsers();
    }
}
