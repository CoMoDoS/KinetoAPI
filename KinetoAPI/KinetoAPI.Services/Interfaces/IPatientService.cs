using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data.Entities;

namespace KinetoAPI.Services.Interfaces
{
    public interface IPatientService
    {
        Task<PatientDto> GetByIdAsync(int id);
        Task<IEnumerable<PatientDto>> GetAll();
    }
}