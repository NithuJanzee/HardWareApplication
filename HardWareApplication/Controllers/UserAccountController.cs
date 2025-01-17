using HardWareApplication.DTO.UserAccounts;
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

        //Post New User
        [HttpPost("AddNewUserAccount")]
        public async Task<IActionResult> AddNewUserAccount(UserAccountRequestDTO requestDTO)
        {
            var response = await _UserAcoountService.AddNewUserAccount(requestDTO);
            return Ok(response);
        }
    }
}
