

namespace DesignePatterns.StructuralPatterns.Adapter
{
    // New Interface the Client Need
    public interface IUserService
    {
        string GetUserName();
    }


    // old class that we cant change
    public class ExternalUserApi
    {
        public ExternalUser FetchUser()
            => new ExternalUser { FirstName = "Ali", LastName = "Rezaei" };
    }
    public class ExternalUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // mange classes with adabpter
    public class UserServiceAdapter : IUserService
    {
        private readonly ExternalUserApi _externalUserApi;

        public UserServiceAdapter(ExternalUserApi externalUserApi)
        {
            _externalUserApi = externalUserApi;
        }

        public string GetUserName()
        {
            var user = _externalUserApi.FetchUser();
            return $"{user.FirstName} {user.LastName}";
        }
    }
}
