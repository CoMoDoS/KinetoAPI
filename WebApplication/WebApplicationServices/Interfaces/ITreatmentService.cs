using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationData.Entities;

namespace WebApplicationServices.Interfaces
{
    public interface ITreatmentService
    {
        Task<TreatmentDto> GetByIdAsync(int id);
        Task<IEnumerable<TreatmentDto>> GetAll();
    }
}