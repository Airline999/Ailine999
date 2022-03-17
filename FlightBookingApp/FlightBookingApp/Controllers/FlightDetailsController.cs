using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FlightBookingApp.Models;

namespace FlightBookingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightDetailsController : ControllerBase
    {
        private readonly airline_reservationContext _context;

        public FlightDetailsController(airline_reservationContext context)
        {
            _context = context;
        }

        // GET: api/FlightDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FlightDetails>>> GetFlightDetails()
        {
            return await _context.FlightDetails.ToListAsync();
        }

        // GET: api/FlightDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FlightDetails>> GetFlightDetails(int id)
        {
            var flightDetails = await _context.FlightDetails.FindAsync(id);

            if (flightDetails == null)
            {
                return NotFound();
            }

            return flightDetails;
        }

        // PUT: api/FlightDetails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlightDetails(int id, FlightDetails flightDetails)
        {
            if (id != flightDetails.FlightId)
            {
                return BadRequest();
            }

            _context.Entry(flightDetails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightDetailsExists(id))
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

        // POST: api/FlightDetails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FlightDetails>> PostFlightDetails(FlightDetails flightDetails)
        {
            _context.FlightDetails.Add(flightDetails);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FlightDetailsExists(flightDetails.FlightId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFlightDetails", new { id = flightDetails.FlightId }, flightDetails);
        }

        // DELETE: api/FlightDetails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FlightDetails>> DeleteFlightDetails(int id)
        {
            var flightDetails = await _context.FlightDetails.FindAsync(id);
            if (flightDetails == null)
            {
                return NotFound();
            }

            _context.FlightDetails.Remove(flightDetails);
            await _context.SaveChangesAsync();

            return flightDetails;
        }

        private bool FlightDetailsExists(int id)
        {
            return _context.FlightDetails.Any(e => e.FlightId == id);
        }
    }
}
