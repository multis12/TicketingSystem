using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TicketingSystem.Infrastructure.Data.Configuration
{
    internal class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(CreateRoles());
        }

        private List<IdentityRole> CreateRoles()
        {
            var roles = new List<IdentityRole>();

            var role = new IdentityRole()
            {
                Id = "1",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR"
            };

            roles.Add(role);

            role = new IdentityRole()
            {
                Id = "2",
                Name = "Client",
                NormalizedName = "CLIENT"
            };

            roles.Add(role);

            role = new IdentityRole()
            {
                Id = "3",
                Name = "Staff",
                NormalizedName = "STAFF"
            };

            roles.Add(role);

            return roles;
        }
    }
}
