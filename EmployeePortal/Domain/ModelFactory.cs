using Domain.Models;

namespace Domain
{
    public class ModelFactory
    {
        public IModel getModel(string modelType)
        {
            IModel model=null;
            if (modelType.Equals("login"))
            {
                model = new LoginModel();
            }
            else if (modelType.Equals("register"))
            {
                model = new RegistrationModel();
            }
            return model;
        }
    }
}