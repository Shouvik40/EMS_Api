using EmsEntity;
using System.Collections.Generic;

namespace EmsData.Repository
{
    public interface IUserMasterRepo
    {
        IList<User_Master> GetAllUserMasters();
        User_Master GetUserMasterById(string id);
        void AddUserMaster(User_Master userMaster);
        Task<User_Master> GetUserByUsername(string username);
        void UpdateUserMaster(User_Master userMaster);
        void DeleteUserMaster(string id);
    }
}
