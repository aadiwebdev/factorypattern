using Domain.Enums;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UserRepo
    {
        public List<UserModel> GetUserDetails(UserRoleChoice userRoleChoice)
        {
            List<UserModel> usersList=null;
            switch ((int)userRoleChoice)
            {
                case 1 :
                        usersList = (List<UserModel>)DataSource._userList.Where(m => m.IsStudent == "yes");
                         break;
                case 2 :
                        usersList = (List<UserModel>)DataSource._userList.Where(m => m.IsStudent == "no");
                         break;
                case 3:
                    usersList = DataSource._userList;
                    break;
            }
            return usersList;
        }
    }
}
