﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsTrackerUI.Models.MainWindowModel
{
    public class User
    {
        private string name;

        public string Name { get => name; set => name = value; }

        
        private string email;
        public string Email { get => email; set => email=value; }

    }
}
