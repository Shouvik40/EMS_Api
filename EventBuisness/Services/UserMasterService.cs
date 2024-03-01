using EmsData.Repository;
using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Services
{
    public class UserMasterService
    {
        private readonly IUserMasterRepo _userMasterRepo;

        public UserMasterService(IUserMasterRepo userMasterRepo)
        {
            _userMasterRepo = userMasterRepo;
        }

        public IList<User_Master> GetAllUserMasters()
        {
            return _userMasterRepo.GetAllUserMasters();
        }

        public User_Master GetUserMasterById(string id)
        {
            return _userMasterRepo.GetUserMasterById(id);
        }

        public void AddUserMaster(User_Master userMaster)
        {
            _userMasterRepo.AddUserMaster(userMaster);
        }

        public void UpdateUserMaster(User_Master userMaster)
        {
            _userMasterRepo.UpdateUserMaster(userMaster);
        }

        public void DeleteUserMaster(string id)
        {
            _userMasterRepo.DeleteUserMaster(id);
        }
    }
}
