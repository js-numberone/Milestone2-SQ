using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorApp1Test.Server.Data;
using BlazorApp1Test.Shared;

namespace BlazorApp1Test.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttitudeParametersController : ControllerBase
    {
        private readonly GForceParametersContext _context;

        public AttitudeParametersController(GForceParametersContext context)
        {
            _context = context;
        }

        // GET: api/AttitudeParameters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AttitudeParamater>>> GetAttitudeParameters()
        {
            return await _context.AttitudeParameters.ToListAsync();
        }

        // GET: api/AttitudeParameters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AttitudeParamater>> GetAttitudeParameters(int id)
        {
            var attitudeParameters = await _context.AttitudeParameters.FindAsync(id);

            if (attitudeParameters == null)
            {
                return NotFound();
            }

            return attitudeParameters;
        }

        // PUT: api/AttitudeParameters/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAttitudeParameters(int id, AttitudeParamater attitudeParameters)
        {
            if (id != attitudeParameters.GForceID)
            {
                return BadRequest();
            }

            _context.Entry(attitudeParameters).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttitudeParametersExists(id))
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

        // POST: api/AttitudeParameters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<AttitudeParamater>> PostAttitudeParameters(AttitudeParamater attitudeParameters)
        {
            _context.AttitudeParameters.Add(attitudeParameters);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAttitudeParameters", new { id = attitudeParameters.GForceID }, attitudeParameters);
        }

        // DELETE: api/AttitudeParameters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AttitudeParamater>> DeleteAttitudeParameters(int id)
        {
            var attitudeParameters = await _context.AttitudeParameters.FindAsync(id);
            if (attitudeParameters == null)
            {
                return NotFound();
            }

            _context.AttitudeParameters.Remove(attitudeParameters);
            await _context.SaveChangesAsync();

            return attitudeParameters;
        }

        private bool AttitudeParametersExists(int id)
        {
            return _context.AttitudeParameters.Any(e => e.GForceID == id);
        }
    }
}
