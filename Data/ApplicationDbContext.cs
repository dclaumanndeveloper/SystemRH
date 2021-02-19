using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using SystemRH.Models;

namespace SystemRH.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SystemRH.Models.Login> Login { get; set; }
        public DbSet<SystemRH.Models.Recruiter> Recruiter { get; set; }
        public DbSet<SystemRH.Models.Candidate> Candidate { get; set; }
    }
}
