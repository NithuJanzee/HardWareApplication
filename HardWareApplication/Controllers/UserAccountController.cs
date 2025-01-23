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

        //Get All UserAccounts
        [HttpGet]
        public async Task<IActionResult> GetAllUsersAccounts()
        {
            var response = await _UserAcoountService.GetAllUsersAccounts();
            return Ok(response);
        }

        //delete users
        [HttpDelete("UserID")]
        public async Task<IActionResult> DeleteUsers(Guid UserId)
        {
            var response = await _UserAcoountService.DeleteUsers(UserId);
            var res = new { message = "User Deleted Successfully" };
            return Ok(res);
        }
        //find User By Id
        [HttpGet("UserID")]
        public async Task<IActionResult> GetByID(Guid UserId)
        {
            var data = await _UserAcoountService.GetByID(UserId);
            return Ok(data);
        }
        //Update Users
        [HttpPut("UserID")]
        public async Task<IActionResult>UpdateUsers(Guid UserId, UserAccountRequestDTO requestDTO)
        {
            var response = await _UserAcoountService.UpdateUsers(UserId, requestDTO);
            return Ok(response);
        }
    }
}
