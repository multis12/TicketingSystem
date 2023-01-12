using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TicketingSystem.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {


            base.OnModelCreating(builder);
        }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<MessageCondition> MessageConditions { get; set; }

        public DbSet<Type> Types { get; set; }

        public DbSet<Project> Projects { get; set; }
    }
}