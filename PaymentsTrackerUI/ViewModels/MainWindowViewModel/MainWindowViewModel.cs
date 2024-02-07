using PaymentsTrackerUI.Models.MainWindowModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PaymentsTrackerUI.ViewModels.MainWindowViewModel
{
    public class MainWindowViewModel
    {

        private PaymentsTrackerServiceClient wcfServiceClient;
        public ObservableCollection<User> Users { get; set; }

        public MainWindowViewModel()
        {
            wcfServiceClient=new PaymentsTrackerServiceClient();
            this.Users= GetAllUsers();
        }

        public static ObservableCollection<User> GetAllUsers()
        {
            //call service
            return new ObservableCollection<User>() { new User { Email = "gaurav.deopa4@gmail.com", Name = "Gaurav Deopa", IsSelected = false }, new User { Email = "gaurav.deopa24@gmail.com", Name = "Gaurav Deopa2", IsSelected = true } };

        }
    }
}
