using HardWareApplication.DTO.UserAccounts;
using HardWareApplication.Entity;

namespace HardWareApplication.Interface.IService.Users
{
    public interface IUserAccountService
    {
        Task<UserAccounts> AddNewUserAccount(UserAccountRequestDTO requestDTO);
    }
}
