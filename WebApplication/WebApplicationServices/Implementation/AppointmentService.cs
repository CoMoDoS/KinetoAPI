using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationData;
using WebApplicationData.Entities;
using WebApplicationServices.Interfaces;

namespace WebApplicationServices.Implementation
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppointmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<AppointmentDto> GetByIdAsync(int id)
        {
            var appointment = await _unitOfWork.AppointmentRepository.GetByIdAsync(id);
            
            return appointment;
        }

        public async Task<IEnumerable<AppointmentDto>> GetAll()
        {
            var appointments = await _unitOfWork.AppointmentRepository.GetAll();
            
            return appointments;
        }
    }
}