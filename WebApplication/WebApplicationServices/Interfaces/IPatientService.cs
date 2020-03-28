using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplicationData.Entities;

namespace WebApplicationServices.Interfaces
{
    public interface IPatientService
    {
        Task<PatientDto> GetByIdAsync(int id);
        Task<IEnumerable<PatientDto>> GetAll();
    }
}