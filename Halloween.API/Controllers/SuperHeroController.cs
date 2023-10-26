using Halloween.API.DTO;
using Halloween.Repo.Interfaces;
using Halloween.Repo.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Halloween.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        // Dependency injection    
        ISuperHeroRepo SuperHeroRepo { get; set; }
        public SuperHeroController(ISuperHeroRepo superHeroRepo)
        {
            this.SuperHeroRepo = superHeroRepo;
        }

        // GET: api/<SuperHeroController>
        [HttpGet] //Data annotation / Attribute
        public List<SuperHero> Get()
        {
            return SuperHeroRepo.GetAll();
        }

        // GET api/<SuperHeroController>/5
        [HttpGet("{id}")]
        public SuperHero Get(int id)
        {
            return SuperHeroRepo.GetById(id);
        }

        // POST api/<SuperHeroController>
        [HttpPost("Create")]
        public void Post([FromBody] SuperHero hero)
        {
            SuperHeroRepo.Create(hero);
        }

        // PUT api/<SuperHeroController>/5
        [HttpPut("{id}")]
        public void Put(int id, SuperHero hero)
        {
            SuperHeroRepo.Update(hero);
        }

        // DELETE api/<SuperHeroController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SuperHeroRepo.Delete(id);
        }
    }
}
