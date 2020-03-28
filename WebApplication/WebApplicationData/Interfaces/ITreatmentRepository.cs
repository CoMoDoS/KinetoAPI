using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationData.Entities;

namespace WebApplicationData.Interfaces
{
    public interface ITreatmentRepository
    {
        Task<TreatmentDto> GetByIdAsync(long id);
        Task<IEnumerable<TreatmentDto>> GetAll();
    }
}