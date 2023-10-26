using Halloween.API.DTO;
using Halloween.Repo.DTO;
using Halloween.Repo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween.Repo.Repositories
{
    public class SuperHeroRepo : ISuperHeroRepo
    {
        Dbcontext context; // Database
        public SuperHeroRepo(Dbcontext temp)
        {
            context = temp;
        }

        public SuperHero Create(SuperHero hero)
        {
            context.SuperHero.Add(hero);
            context.SaveChangesAsync();
            return hero;
        }

        public void Delete(int id)
        {
            context.SuperHero.Where(x => x.Id == id)?.ExecuteDelete();
        }

        public List<SuperHero> GetAll()
        {
            // Database.Tablename.Where
            return context.SuperHero.ToList(); // Take it all
        }

        public SuperHero GetById(int id)
        {
            return context.SuperHero.First(x => x.Id == id);
        }

        public SuperHero Update(SuperHero hero)
        {
            context.SuperHero.Update(hero);
            context.SaveChanges();
            return hero;
        }
    }
}
