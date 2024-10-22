using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace SmartCitySecurity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidentController : ControllerBase
    {
        private readonly DataContext _context;

        public IncidentController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetIncidents()
        {
            var incidents = await _context.Incidents.ToListAsync();
            return Ok(incidents);
        }

        [HttpPost]
        public async Task<IActionResult> ReportIncident([FromBody] Incident incident)
        {
            incident.ReportedAt = DateTime.Now;
            _context.Incidents.Add(incident);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Incident reported successfully" });
        }
    }
}
