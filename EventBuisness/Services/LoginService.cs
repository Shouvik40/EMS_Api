using EmsData.Repository;
using EmsEntity;
using System.Collections.Generic;
namespace EmsServices
{
    public class LoginService : ILoginService
    {
        private readonly IUserMasterRepo _userMasterRepository;

        public LoginService(IUserMasterRepo userMasterRepository)
        {
            _userMasterRepository = userMasterRepository;
        }

        public async Task<User_Master> Authenticate(string userName, string password, string userType)
        {
            var user = await _userMasterRepository.GetUserByUsername(userName);

            if (user != null && user.UserPassword == password && user.UserType == userType)
            {
                return user;
            }

            return null;
        }

    }
}
