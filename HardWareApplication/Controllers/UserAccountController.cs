using HardWareApplication.Interface.IService.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HardWareApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAccountController : ControllerBase
    {
        private readonly IUserAccountService _UserAcoountService;
        public UserAccountController(IUserAccountService userAcoountService)
        {
            _UserAcoountService = userAcoountService;
        }
    }
}
