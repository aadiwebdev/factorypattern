

namespace Domain.Models
{
    public class LoginModel:IUserLogin
    {
        public LoginModel()
        {
        }

        public LoginModel(string emailAddress, string password)
        {
            EmailAddress = emailAddress;
            Password = password;
        }
        public string EmailAddress { get; set; }
        public string Password { get; set; }

    }
}
