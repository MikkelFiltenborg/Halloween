using Halloween.Repo.DTO;
using Halloween.Repo.Interfaces;
using Halloween.Repo.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Halloween.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        ITeamRepo TeamRepo { get; set; }

        public TeamController(ITeamRepo teamRepo)
        {
            TeamRepo = teamRepo;
        }

        // GET: api/<TeamController>
        [HttpGet]
        public List<Team> Get()
        {
            return TeamRepo.GetAll();
        }

        // GET api/<TeamController>/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return TeamRepo.GetById(id);
        }

        //public async Task<ActionResult<Team>> Get(int id)
        //{
        //    try
        //    {
        //        if (id is null or 0)
        //        {
        //            return BadRequest($"Team not found at id. id was {id}");
        //        }
        //        return TeamRepo.GetById(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"An error occurred while creating the team. {ex}");
        //    }
        //}

        // POST api/<TeamController>
        [HttpPost("Create")]
        public async Task<ActionResult<Team>> PostTeam(Team team)
        {
            try
            {
                var createTeam = await TeamRepo.Create(team);

                if (createTeam == null)
                {
                    return BadRequest("Team not found or not created");
                }

                return CreatedAtAction("PostTeam", new { teamId = createTeam.Id }, createTeam);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the team. {ex}");
            }
        }


        // PUT api/<TeamController>/5
        [HttpPut("{id}")]
        public void Put(int id, Team team)
        {
            TeamRepo.Update(team);
        }

        // DELETE api/<TeamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TeamRepo.Delete(id);
        }
    }
}
