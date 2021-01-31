using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data.Entities;

namespace KinetoAPI.Data.Interfaces
{
    public interface IPatientRepository
    {
        Task<PatientDto> GetByIdAsync(long id);
        Task<IEnumerable<PatientDto>> GetAll();
    }
}