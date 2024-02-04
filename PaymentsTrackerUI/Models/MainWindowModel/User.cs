using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsTrackerUI.Models.MainWindowModel
{
    public class User
    {
        private string name;

        private bool isSelected;

        private string email;

        public string Name { get => name; set => name = value; }

        public bool IsSelected { get => isSelected; set => isSelected = value; }
        
        public string Email { get => email; set => email=value; }

    }
}
