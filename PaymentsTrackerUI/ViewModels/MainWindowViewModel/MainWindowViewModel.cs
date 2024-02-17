using PaymentsTrackerUI.Models.MainWindowModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserService;
using static UserService.UserServiceClient;

namespace PaymentsTrackerUI.ViewModels.MainWindowViewModel
{
    public class MainWindowViewModel
    {

        public ObservableCollection<UserModel> Users { get; set; }

        public MainWindowViewModel()
        {
            this.Users= GetAllUsers();
        }

        public static ObservableCollection<UserModel> GetAllUsers()
        {

            List<UserService.User> userList = new List<UserService.User>();
            UserServiceClient userServiceClient = new UserServiceClient(EndpointConfiguration.BasicHttpBinding_IUserService);
            userList = userServiceClient.GetAllUsers();
            List<UserModel> userModlList = new List<UserModel>();
            foreach(User user in userList)
            {
                UserModel userModl = new UserModel();
                userModl.Name=user.Name;
                userModl.Email=user.Email;
                userModlList.Add(userModl);
            }
            ObservableCollection<UserModel> users = new ObservableCollection<UserModel>(userModlList);
            return users;
        }
    }
}
