using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<UserDto> Get([FromQuery] int id)
        {
            var user = await _userService.GetByIdAsync(id);
            return user;
        }
    }
}