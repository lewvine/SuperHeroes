using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SuperHeroes.Models;

namespace SuperHeroes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<SuperHero> SuperHeroes { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
