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
    }
}
