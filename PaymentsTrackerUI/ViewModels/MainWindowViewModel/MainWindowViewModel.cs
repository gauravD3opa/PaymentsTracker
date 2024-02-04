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
        public ObservableCollection<User> Users { get; set; }

        private UserManager _UserManager;
        public MainWindowViewModel()
        {
            this._UserManager=new UserManager();
            this.Users= this._UserManager.GetAllUsers();
        }
    }
}
