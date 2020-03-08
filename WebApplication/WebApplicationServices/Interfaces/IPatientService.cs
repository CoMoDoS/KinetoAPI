using System.Threading.Tasks;

namespace WebApplicationServices.Interfaces
{
    public class IPatientService
    {
        Task<PatientDto> GetByIdAsync(int id);
    }
}