using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsTrackerUI.Models.MainWindowModel
{
    internal class MainWindowModel
    {
        public List<User> usersList = new List<User>();

    }

    internal class User
    {
        private string name;

        string Name { get => name; set => name = value; }

    }
}
