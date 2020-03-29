using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationData.Entities;
using WebApplicationServices.Interfaces;

namespace WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int id)
        {
            var appointment = await _appointmentService.GetByIdAsync(id);
            
            return Ok(appointment);
        }
        
        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<AppointmentDto>> GetAll()
        {
            var appointments = await _appointmentService.GetAll();

            return appointments;
        }
    }
}