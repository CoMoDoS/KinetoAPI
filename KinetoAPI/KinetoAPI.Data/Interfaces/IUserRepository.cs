using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data.Entities;

namespace KinetoAPI.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDto> GetByIdAsync(long id);
        Task<IEnumerable<UserDto>> GetAll();
    }
}