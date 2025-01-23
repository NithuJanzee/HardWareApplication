using HardWareApplication.DTO.UserAccounts;
using HardWareApplication.Entity;

namespace HardWareApplication.Interface.IRepository.Users
{
    public interface IUserAccountRepository
    {
        Task<UserAccounts> AddNewUserAccount(UserAccounts userAccounts);
        Task<List<UserAccounts>> GetAllUsersAccounts();
        Task<UserAccounts> DeleteUsers(Guid UserId);
        Task<UserAccounts> GetByID(Guid UserId);
        Task<UserAccounts> UpdateUsers(Guid UserId, UserAccountRequestDTO requestDTO);
    }
}
