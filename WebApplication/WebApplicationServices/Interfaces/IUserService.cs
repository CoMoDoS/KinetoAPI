using System.Threading.Tasks;
using WebApplicationData.Entities;
using WebApplicationModels.User;

namespace WebApplicationServices.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(int id);
    }
}