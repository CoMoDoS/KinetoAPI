using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationData.Entities;
using WebApplicationServices.Interfaces;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentController : ControllerBase
    {
        private readonly ITreatmentService _treatmentService;

        public TreatmentController(ITreatmentService treatmentService)
        {
            _treatmentService = treatmentService;
        }
        
        [HttpGet]
        public async Task<TreatmentDto> Get([FromQuery] int id)
        {
            var treatment = await _treatmentService.GetByIdAsync(id);
            
            return treatment;
        }
        
        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<TreatmentDto>> GetAll()
        {
            var treatments = await _treatmentService.GetAll();

            return treatments;
        }
    }
}