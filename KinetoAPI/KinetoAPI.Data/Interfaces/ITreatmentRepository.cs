using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data.Entities;

namespace KinetoAPI.Data.Interfaces
{
    public interface ITreatmentRepository
    {
        Task<TreatmentDto> GetByIdAsync(long id);
        Task<IEnumerable<TreatmentDto>> GetAll();
    }
}