

using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplyNow.Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<ApplicationModel> Applications { get; set; }
        //public DbSet<ApplicationStatus> ApplicationStatuses { get; set; }

    }
}
