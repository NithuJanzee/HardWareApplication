using HardWareApplication.Data;
using HardWareApplication.DTO.UserAccounts;
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

        //Get All UserAccounts
        public async Task<List<UserAccounts>> GetAllUsersAccounts()
        {
            var AllUsers = await _dbContext.userAccounts.ToListAsync();
            return AllUsers;
        }

        //delete user account 
        public async Task<UserAccounts> DeleteUsers(Guid UserId)
        {
            var findUsers = await _dbContext.userAccounts.FindAsync(UserId);
            if (findUsers == null)
            {
                throw new Exception("User Not Found");
            }

            _dbContext.userAccounts.Remove(findUsers);
            await _dbContext.SaveChangesAsync();
            return findUsers;
        }

        //Get User By Id
        public async Task<UserAccounts> GetByID(Guid UserId)
        {
            var Users = await _dbContext.userAccounts.FindAsync(UserId);
            if (Users == null)
            {
                throw new Exception("User Not Found");
            }
            return Users;
        }

        //Update Users
        public async Task<UserAccounts> UpdateUsers(Guid UserId , UserAccountRequestDTO requestDTO)
        {
            var FindExitingUsers = await _dbContext.userAccounts.FindAsync(UserId);
            if (FindExitingUsers == null)
            {
                throw new Exception("User Not Found");
            }
             FindExitingUsers.Name = requestDTO.Name;
            FindExitingUsers.Email = requestDTO.Email;
            FindExitingUsers.PhoneNumber = requestDTO.PhoneNumber;
            await _dbContext.SaveChangesAsync();

            return FindExitingUsers;
        }
    }
}
