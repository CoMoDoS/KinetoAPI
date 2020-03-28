using System.Collections.Generic;
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
            var userModel = await _unitOfWork.UserRepository.GetByIdAsync(id);
            
            return userModel;
        }
        
        public async Task<IEnumerable<UserDto>> GetAll()
        {
            var users = await _unitOfWork.UserRepository.GetAll();
            
            return users;
        }
    }
}