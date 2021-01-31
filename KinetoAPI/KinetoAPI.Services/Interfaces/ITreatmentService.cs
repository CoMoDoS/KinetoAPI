using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data.Entities;

namespace KinetoAPI.Services.Interfaces
{
    public interface ITreatmentService
    {
        Task<TreatmentDto> GetByIdAsync(int id);
        Task<IEnumerable<TreatmentDto>> GetAll();
    }
}