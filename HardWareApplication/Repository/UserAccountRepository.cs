using HardWareApplication.Data;
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
    }
}
