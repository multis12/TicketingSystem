using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TicketingSystem.Infrastructure.Data.Configuration
{
    internal class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {

        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(CreateUsers());
        }

        private List<AppUser> CreateUsers()
        {
            var users = new List<AppUser>();
            var hasher = new PasswordHasher<AppUser>();

            var user = new AppUser()
            {
                Id = "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2",
                UserName = "Client",
                NormalizedUserName = "CLIENT",
                Email = "client@mail.com",
                NormalizedEmail = "CLIENT@MAIL.COM",
                FirstName = "Client",
                SecondName = "Client",
                IsActive = true,
                AccountRoleId = 2
            };

            user.PasswordHash = hasher.HashPassword(user, "Client123");

            users.Add(user);

            user = new AppUser()
            {
                Id = "a02a086f-e7a3-4dba-9732-d92a137c1158",
                UserName = "Staff",
                NormalizedUserName = "STAFF",
                Email = "staff@mail.com",
                NormalizedEmail = "STAFF@MAIL.COM",
                FirstName = "Staff",
                SecondName = "Staff",
                IsActive = true,
                AccountRoleId = 3
            };

            user.PasswordHash = hasher.HashPassword(user, "Staff123");

            users.Add(user);

            user = new AppUser()
            {
                Id = "fe738829-bae4-46ec-a545-ed40aee912ea",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Admin",
                SecondName = "Admin",
                IsActive = true,
                AccountRoleId = 1
            };

            user.PasswordHash = hasher.HashPassword(user, "Admin123");

            users.Add(user);

            return users;
        }
    }
}
