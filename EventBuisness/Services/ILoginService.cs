using EmsEntity;
using System.Threading.Tasks;

namespace EmsServices
{
    public interface ILoginService
    {
        Task<User_Master> Authenticate(string userName, string password,string userType);
    }
}
