using System.Collections.Generic;
using System.Threading.Tasks;
using KinetoAPI.Data;
using KinetoAPI.Data.Entities;
using KinetoAPI.Services.Interfaces;

namespace KinetoAPI.Services.Implementation
{
    public class TreatmentService : ITreatmentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TreatmentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public async Task<TreatmentDto> GetByIdAsync(int id)
        {
            var treatment = await _unitOfWork.TreatmentRepository.GetByIdAsync(id);
            
            return treatment;
        }
        
        public async Task<IEnumerable<TreatmentDto>> GetAll()
        {
            var treatments = await _unitOfWork.TreatmentRepository.GetAll();
            
            return treatments;
        }
    }
}