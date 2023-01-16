using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Id = "1a3c1aad-89c2-444f-88ef-ce265a341270",
                UserName = "Client",
                NormalizedUserName = "CLIENT",
                Email = "client@mail.com",
                NormalizedEmail = "CLIENT@MAIL.COM",
                FirstName = "Client",
                SecondName = "Client"
            };

            user.PasswordHash = hasher.HashPassword(user, "Client123");

            users.Add(user);

            user = new AppUser()
            {
                Id = "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                UserName = "Staff",
                NormalizedUserName = "STAFF",
                Email = "staff@mail.com",
                NormalizedEmail = "STAFF@MAIL.COM",
                FirstName = "Staff",
                SecondName = "Staff"
            };

            user.PasswordHash = hasher.HashPassword(user, "Staff123");

            users.Add(user);

            user = new AppUser()
            {
                Id = "622d93dd-682c-4370-999b-6c4315ccceea",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                Email = "admin@mail.com",
                NormalizedEmail = "ADMIN@MAIL.COM",
                FirstName = "Admin",
                SecondName = "Admin"
            };

            user.PasswordHash = hasher.HashPassword(user, "Admin123");

            users.Add(user);

            return users;
        }
    }
}
