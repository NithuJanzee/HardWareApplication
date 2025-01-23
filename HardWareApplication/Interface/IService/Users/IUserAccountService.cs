using HardWareApplication.DTO.UserAccounts;
using HardWareApplication.Entity;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HardWareApplication.Interface.IService.Users
{
    public interface IUserAccountService
    {
        Task<UserAccounts> AddNewUserAccount(UserAccountRequestDTO requestDTO);
        Task<List<UserAccounts>> GetAllUsersAccounts();
        Task<bool> DeleteUsers(Guid UserID);
        Task<UserAccounts> GetByID(Guid UserID);
        Task<UserAccounts> UpdateUsers(Guid Id, UserAccountRequestDTO requestDTO);
    }
}
