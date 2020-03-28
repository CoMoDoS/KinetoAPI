using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationData.Entities;
using WebApplicationServices.Interfaces;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet]
        public async Task<PatientDto> Get([FromQuery] int id)
        {
            var patient = await _patientService.GetByIdAsync(id);
            return patient;
        }
        
        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<PatientDto>> GetAll()
        {
            var patients = await _patientService.GetAll();

            return patients;
        }
    }
}