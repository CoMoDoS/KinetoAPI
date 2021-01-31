using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data;
using KinetoAPI.Data.Entities;
using KinetoAPI.Services.Interfaces;

namespace KinetoAPI.Services.Implementation
{
    public class PatientService : IPatientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<PatientDto> GetByIdAsync(int id)
        {
            var patient = await _unitOfWork.PatientRepository.GetByIdAsync(id);
            
            return patient;
        }
        
        public async Task<IEnumerable<PatientDto>> GetAll()
        {
            var patients = await _unitOfWork.PatientRepository.GetAll();
            
            return patients;
        }
    }
}