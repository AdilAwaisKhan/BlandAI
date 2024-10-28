using BlandAI.Data;
using BlandAI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BlandAI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaveInfoController : ControllerBase
    {
        private readonly InfoDbContext _context;

        public SaveInfoController(InfoDbContext context)
        {
            _context=context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Info>>> GetInfo()
        {
            return await _context.Infos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Info>> PostStudent(Info info)
        {
            _context.Infos.Add(info);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInfo), new { id = info.Id }, info);
        }

    }
}
