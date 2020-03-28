using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationData.Entities;

namespace WebApplicationData.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<AppointmentDto> GetByIdAsync(long id);
        Task<IEnumerable<AppointmentDto>> GetAll();
    }
}