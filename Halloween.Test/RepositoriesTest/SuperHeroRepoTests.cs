using Halloween.API.DTO;
using Halloween.Repo.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween.Test.RepositoriesTest
{
    /// <summary>
    /// We Want to take the DB offline, so we can focus on Repo Layer
    /// To do that we use InMemoryDB
    /// The way we does that is
    /// *copy DbContext and Options*
    /// 
    /// </summary>
    public class SuperHeroRepoTests
    {      
        public Dbcontext context { get; set; }
        public DbContextOptions<Dbcontext> options;
        private SuperHeroRepo heroRepo;

        // parans later...
        // Constructor
        public SuperHeroRepoTests()
        {
            // Torsdag is a random name. Change it to something else if there are Errors.
            options = new DbContextOptionsBuilder<Dbcontext>()
                .UseInMemoryDatabase("Torsdag").Options;
            // we init out "DB"
            context = new Dbcontext(options);

            SuperHero hero1 = new SuperHero()
            {
                Id = 1,
                Name = "Spiderman",
                RealName = "Park Peeter",
                Place = "Earth",
                DebutYear = DateTime.Now
            };
            SuperHero hero2 = new SuperHero()
            {
                Id = 2,
                Name = "Sonic",
                RealName = "Sonic The Headgehog",
                Place = "OtherDimention",
                DebutYear = DateTime.Now
            };
            SuperHero hero3 = new SuperHero()
            {
                Id = 3,
                Name = "Ironman",
                RealName = "Tony Stark",
                Place = "Earth",
                DebutYear = DateTime.Now
            };
            context.SuperHero.Add(hero1);
            context.SuperHero.Add(hero2);
            context.SuperHero.Add(hero3);
            context.SaveChanges();
        }

        [Fact]
        public void GetAllShouldReturnListOfHeroes_WhenHeroesExist()
        {
            //Arrange - cretae objects / variabels / something
            //SuperHeroRepo hero = new SuperHeroRepo();
            heroRepo = new SuperHeroRepo(context);


            //Act - actions(Handlinger)
            //Invoke GetAll...
            //var result = heroRepo.GetAll();

            //Assert - Testing if our result is what we want it to be
            //Assert.NotNull(result);
            //Assert.IsType<List<SuperHero>>(result);
            //Assert.Equal(3, result.Count);
        }

        //Arrange

        //Act

        //Assert
    }
}
