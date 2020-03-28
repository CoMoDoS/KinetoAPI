using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationData.Entities;
using WebApplicationData.Interfaces;
using WebApplicationServices.Interfaces;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<UserDto> Get([FromQuery] int id)
        {
            var user = await _userService.GetByIdAsync(id);
            
            return user;
        }

        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var users = await _userService.GetAll();

            return users;
        }
    }
}
