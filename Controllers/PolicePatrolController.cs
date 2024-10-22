using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace SmartCitySecurity.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PolicePatrolController : ControllerBase
    {
        private readonly DataContext _context;

        public PolicePatrolController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetPatrols()
        {
            var patrols = await _context.PolicePatrols.ToListAsync();
            return Ok(patrols);
        }

        [HttpPost]
        public async Task<IActionResult> AssignPatrol([FromBody] PolicePatrol patrol)
        {
            patrol.AssignedAt = DateTime.Now;
            patrol.Status = "Assigned";
            _context.PolicePatrols.Add(patrol);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Police patrol assigned successfully" });
        }
    }
}
