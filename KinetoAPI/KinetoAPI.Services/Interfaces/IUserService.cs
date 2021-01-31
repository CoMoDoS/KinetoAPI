using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data.Entities;

namespace KinetoAPI.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(int id);
        Task<IEnumerable<UserDto>> GetAll();
    }
}