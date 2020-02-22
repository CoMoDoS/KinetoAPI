using System.Threading.Tasks;
using WebApplicationData.Entities;

namespace WebApplicationData.Interfaces
{
    public interface IUserRepository
    {
        Task<UserDto> GetByIdAsync(long id);
    }
}