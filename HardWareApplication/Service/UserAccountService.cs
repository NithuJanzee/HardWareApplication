using HardWareApplication.DTO.UserAccounts;
using HardWareApplication.Entity;
using HardWareApplication.Interface.IRepository.Users;
using HardWareApplication.Interface.IService.Users;

namespace HardWareApplication.Service
{
    public class UserAccountService:IUserAccountService
    {
        private IUserAccountRepository _UserAccountReposirory;

        public UserAccountService(IUserAccountRepository userAccountRepository)
        {
            _UserAccountReposirory = userAccountRepository;
        }

        //Post New User
        public async Task<UserAccounts> AddNewUserAccount(UserAccountRequestDTO requestDTO)
        {
            var userAccount = new UserAccounts
            {
                Name = requestDTO.Name,
                Email = requestDTO.Email,
                PhoneNumber = requestDTO.PhoneNumber
            };

           await _UserAccountReposirory.AddNewUserAccount(userAccount);

            //Response
          return userAccount;
        }

        //Get All UserAccounts
        public async Task<List<UserAccounts>> GetAllUsersAccounts()
        {
            return await _UserAccountReposirory.GetAllUsersAccounts();
        }

        //delete Users
        public async Task<bool> DeleteUsers(Guid UserID)
        {
            var RemoveUsers = await _UserAccountReposirory.DeleteUsers(UserID);
            return true;
        }

        //Find Usee By Id
        public async Task<UserAccounts> GetByID(Guid UserID)
        {
            var FindUsers = await _UserAccountReposirory.GetByID(UserID);
            return FindUsers;
        }

        //Update Users
        public async Task<UserAccounts> UpdateUsers(Guid Id, UserAccountRequestDTO requestDTO)
        {
            var UpdateUsers = await _UserAccountReposirory.UpdateUsers(Id, requestDTO);
            return UpdateUsers;
        }
    }
}
