using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationData.Entities;

namespace WebApplicationData.Interfaces
{
    public interface IPatientRepository
    {
        Task<PatientDto> GetByIdAsync(long id);
        Task<IEnumerable<PatientDto>> GetAll();
    }
}