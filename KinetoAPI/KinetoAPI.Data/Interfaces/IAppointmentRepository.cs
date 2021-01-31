using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data.Entities;

namespace KinetoAPI.Data.Interfaces
{
    public interface IAppointmentRepository
    {
        Task<AppointmentDto> GetByIdAsync(long id);
        Task<IEnumerable<AppointmentDto>> GetAll();
    }
}