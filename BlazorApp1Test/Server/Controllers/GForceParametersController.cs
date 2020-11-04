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
    public class GForceParametersController : ControllerBase
    {
        private readonly GForceParametersContext _context;

        public GForceParametersController(GForceParametersContext context)
        {
            _context = context;
        }

        // GET: api/GForceParameters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GForceParameter>>> GetGForceParameter()
        {
            return await _context.GForceParameters.ToListAsync();
        }

        // GET: api/GForceParameters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GForceParameter>> GetGForceParameter(int id)
        {
            var gForceParameter = await _context.GForceParameters.FindAsync(id);

            if (gForceParameter == null)
            {
                return NotFound();
            }

            return gForceParameter;
        }

        // PUT: api/GForceParameters/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGForceParameter(int id, GForceParameter gForceParameter)
        {
            if (id != gForceParameter.Record_Id)
            {
                return BadRequest();
            }

            _context.Entry(gForceParameter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GForceParameterExists(id))
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

        // POST: api/GForceParameters
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GForceParameter>> PostGForceParameter(GForceParameter gForceParameter)
        {
            _context.GForceParameters.Add(gForceParameter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGForceParameter", new { id = gForceParameter.Record_Id }, gForceParameter);
        }

        // DELETE: api/GForceParameters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GForceParameter>> DeleteGForceParameter(int id)
        {
            var gForceParameter = await _context.GForceParameters.FindAsync(id);
            if (gForceParameter == null)
            {
                return NotFound();
            }

            _context.GForceParameters.Remove(gForceParameter);
            await _context.SaveChangesAsync();

            return gForceParameter;
        }

        private bool GForceParameterExists(int id)
        {
            return _context.GForceParameters.Any(e => e.Record_Id == id);
        }
    }
}
