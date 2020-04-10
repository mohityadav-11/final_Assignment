using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalAssignment_aspNetCore.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpLeaveMapsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EmpLeaveMapsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/EmpLeaveMaps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmpLeaveMap>>> GetempLeaveMaps()
        {
            return await _context.empLeaveMaps.ToListAsync();
        }

        // GET: api/EmpLeaveMaps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmpLeaveMap>> GetEmpLeaveMap(int id)
        {
            var empLeaveMap = await _context.empLeaveMaps.FindAsync(id);

            if (empLeaveMap == null)
            {
                return NotFound();
            }

            return empLeaveMap;
        }

        // PUT: api/EmpLeaveMaps/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpLeaveMap(int id, EmpLeaveMap empLeaveMap)
        {
            if (id != empLeaveMap.mapId)
            {
                return BadRequest();
            }

            _context.Entry(empLeaveMap).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpLeaveMapExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EmpLeaveMaps
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<EmpLeaveMap>> PostEmpLeaveMap(EmpLeaveMap empLeaveMap)
        {
            _context.empLeaveMaps.Add(empLeaveMap);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpLeaveMap", new { id = empLeaveMap.mapId }, empLeaveMap);
        }

        // DELETE: api/EmpLeaveMaps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EmpLeaveMap>> DeleteEmpLeaveMap(int id)
        {
            var empLeaveMap = await _context.empLeaveMaps.FindAsync(id);
            if (empLeaveMap == null)
            {
                return NotFound();
            }

            _context.empLeaveMaps.Remove(empLeaveMap);
            await _context.SaveChangesAsync();

            return empLeaveMap;
        }

        private bool EmpLeaveMapExists(int id)
        {
            return _context.empLeaveMaps.Any(e => e.mapId == id);
        }
    }
}
