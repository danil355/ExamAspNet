using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Domain.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Application> Applications { get; set; }

        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
