using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkCore.Data;
using EntityFrameworkCore.Domain;
using EntityFrameworkCore.Data.WebAPIContext;
using EntityFrameworkCore.API.Modals;

namespace EntityFrameworkCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly FootballLeagueWebAPIContext _context;

        public TeamsController(FootballLeagueWebAPIContext context)
        {
            _context = context;
        }

        // GET: api/Teams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Team>>> GetTeams()
        {
            return await _context.Teams.ToListAsync();
        }

        // GET: api/Teams/dtos
        [HttpGet("GetTeamsWithDTOs")]
        public async Task<ActionResult<IEnumerable<TeamDTO>>> GetTeamsWithDTOs()
        {
            if (_context.Teams == null)
            {
                return NotFound();
            }

            var teams = await _context.Teams
                .Include(t => t.Coaches)
                .Include(t => t.League)
                .Select(t => new TeamDTO
                {
                    Id = t.Id,
                    Name = t.Name,
                    LeagueId = t.LeagueId,
                    LeagueName = t.League.Name,
                    //CoachName = t.Coaches.ToList().Name, // For backward compatibility
                    //CoachName = _context.Coaches.Select(q => q.Name).FirstOrDefault()
                    CoachName = t.Coaches.Select(q => q.Name).ToList()
                }).ToListAsync();
            return teams;
        }

        // GET: api/Teams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);

            if (team == null)
            {
                return NotFound();
            }

            return team;
        }

        // PUT: api/Teams/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeam(int id, Team team)
        {
            if (id != team.Id)
            {
                return BadRequest();
            }

            _context.Entry(team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeamExists(id))
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

        // POST: api/Teams
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Team>> PostTeam(Team team)
        {
            _context.Teams.Add(team);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTeam", new { id = team.Id }, team);
        }

        // DELETE: api/Teams/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTeam(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Teams/dbpath
        [HttpGet("dbpath")]
        public ActionResult<string> GetDatabasePath()
        {
            // Return the database path from the context
            return Ok(_context.DbPath);
        }
        // GET: api/Teams/dbstatus
        [HttpGet("dbstatus")]
        public async Task<ActionResult<string>> GetDatabaseStatus()
        {
            try
            {
                // Try to open a connection to the database
                await _context.Database.OpenConnectionAsync();
                await _context.Database.CloseConnectionAsync();
                return Ok("Database connection successful.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Database connection failed: {ex.Message}");
            }
        }

        private bool TeamExists(int id)
        {
            return _context.Teams.Any(e => e.Id == id);
        }
    }
}
