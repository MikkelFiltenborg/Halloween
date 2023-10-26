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
    // Repo Dbcontext
    public class Dbcontext : DbContext //Entity Framework CORE
    {
        // a class has 2 things (methods and properties)
        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options)
        {
            // if I want a direct accress to the DB, I write it here (Like program.cs)
        }

        // Tabels???
        public DbSet<SuperHero> SuperHero { get; set; }
        public DbSet<Team> Team { get; set; }
    }
}
