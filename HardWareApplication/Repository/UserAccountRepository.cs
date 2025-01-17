using HardWareApplication.Data;
using HardWareApplication.Entity;
using HardWareApplication.Interface.IRepository.Users;
using Microsoft.EntityFrameworkCore;

namespace HardWareApplication.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private readonly AppDbContext _dbContext;

        public UserAccountRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Post New user
        public async Task<UserAccounts> AddNewUserAccount(UserAccounts userAccounts)
        {
            var AddNewAccount = await _dbContext.userAccounts.AddAsync(userAccounts);
            await _dbContext.SaveChangesAsync();
            return AddNewAccount.Entity;
        }
    }
}
