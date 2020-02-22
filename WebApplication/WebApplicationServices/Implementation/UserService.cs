using System.Threading.Tasks;
using WebApplicationData;
using WebApplicationData.Entities;
using WebApplicationModels.User;
using WebApplicationServices.Interfaces;

namespace WebApplicationServices.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<UserDto> GetByIdAsync(int id)
        {
            UserDto userModel= null;
            userModel = await _unitOfWork.UserRepository.GetByIdAsync(id);
            return userModel;
        }
    }
}