

using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ApplyNow.Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);//First Call Dbset For IdentityDbContext User,Roles,...7 Dbset
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());// Call My Config
        }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<ApplicationModel> Applications { get; set; }
        //public DbSet<ApplicationStatus> ApplicationStatuses { get; set; }

    }
}
