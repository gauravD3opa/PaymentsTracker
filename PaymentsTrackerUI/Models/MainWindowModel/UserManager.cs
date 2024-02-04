using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace PaymentsTrackerUI.Models.MainWindowModel
{
    public class UserManager
    { 
        public ObservableCollection<User> GetAllUsers()
        {
            return new ObservableCollection<User>() { new User { Email = "gaurav.deopa4@gmail.com", Name = "Gaurav Deopa", IsSelected=false}, new User { Email = "gaurav.deopa24@gmail.com", Name = "Gaurav Deopa2", IsSelected = true } };

        }
    }
}
