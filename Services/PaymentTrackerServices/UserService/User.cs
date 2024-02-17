using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PaymentTrackerServices.UserService
{
    [DataContract]
    public class User
    {
   
        private string name;

       
        private bool isSelected;

        
        private string email;

        [DataMember]
        public string Name { get => name; set => name = value; }
        [DataMember]
        public bool IsSelected { get => isSelected; set => isSelected = value; }
        [DataMember]
        public string Email { get => email; set => email = value; }

    }
}
