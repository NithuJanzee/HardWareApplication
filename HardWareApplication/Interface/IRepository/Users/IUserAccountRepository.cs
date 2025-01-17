using HardWareApplication.Entity;

namespace HardWareApplication.Interface.IRepository.Users
{
    public interface IUserAccountRepository
    {
        Task<UserAccounts> AddNewUserAccount(UserAccounts userAccounts);
        Task<List<UserAccounts>> GetAllUsersAccounts();
    }
}
