using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationData.Entities;

namespace WebApplicationServices.Interfaces
{
    public interface IAppointmentService
    {
        Task<AppointmentDto> GetByIdAsync(int id);
        Task<IEnumerable<AppointmentDto>> GetAll();
    }
}