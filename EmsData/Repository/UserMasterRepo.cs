using EmsData.EmsDataContext;
using EmsEntity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace EmsData.Repository
{
    public class UserMasterRepo : IUserMasterRepo
    {
        private readonly EmsDbContext _context;

        public UserMasterRepo(EmsDbContext context)
        {
            _context = context;
        }

        public IList<User_Master> GetAllUserMasters()
        {
            return _context.User_Masters.ToList();
        }

        public User_Master GetUserMasterById(string id)
        {
            return _context.User_Masters.Find(id);
        }

        public void AddUserMaster(User_Master userMaster)
        {
            _context.User_Masters.Add(userMaster);
            _context.SaveChanges();
        }

        public void UpdateUserMaster(User_Master userMaster)
        {
            _context.Entry(userMaster).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteUserMaster(string id)
        {
            var userMaster = _context.User_Masters.Find(id);
            if (userMaster != null)
            {
                _context.User_Masters.Remove(userMaster);
                _context.SaveChanges();
            }
        }
    }
}
