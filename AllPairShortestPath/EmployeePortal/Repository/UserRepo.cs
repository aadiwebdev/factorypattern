using Domain.Enums;
using Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class UserRepo
    {
        /// <summary>
        /// Retrieve User details from the repository
        /// </summary>
        /// <param name="userRoleChoice"></param>
        /// <returns></returns>
        public List<UserModel> GetUserDetails(UserRoleChoice userRoleChoice)
        {
            List<UserModel> usersList=null;
            switch ((int)userRoleChoice)
            {
                case 1 :
                        usersList = (List<UserModel>)DataSource._userList.Where(m => m.IsStudent=="yes").ToList<UserModel>();
                         break;
                case 2 :
                        usersList = (List<UserModel>)DataSource._userList.Where(m => m.IsStudent=="no").ToList<UserModel>();
                    break;
                case 3:
                    usersList = DataSource._userList;
                    break;
            }
            return usersList;
        }
    }
}
