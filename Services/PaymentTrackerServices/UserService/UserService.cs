using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PaymentTrackerServices.UserService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in both code and config file together.
    public class UserService : IUserService
    {
        public void DoWork()
        {
            
        }

        public bool IsAlive()
        {
            return true;    
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();    
            DataAccessLayer dl = new DataAccessLayer();
            DataSet ds=new DataSet();
            ds =dl.ExecuteGetAllUsersProcedure();
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    User user = new User();
                    user.Name=row[0].ToString();
                    user.Email = row[1].ToString();
                    users.Add(user);
                }
            }
            return users;
        }
    }
}
