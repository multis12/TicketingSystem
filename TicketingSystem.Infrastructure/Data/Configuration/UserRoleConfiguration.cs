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
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(CreateUsersRoles());
        }

        private List<IdentityUserRole<string>> CreateUsersRoles()
        {
            List<IdentityUserRole<string>> UsersRoles = new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>()
                {
                    RoleId = "1",
                    UserId = "622d93dd-682c-4370-999b-6c4315ccceea"
                },

                new IdentityUserRole<string>()
                {
                    RoleId = "2",
                    UserId = "622d93dd-682c-4370-999b-6c4315ccceea"
                },

                new IdentityUserRole<string>()
                {
                    RoleId = "3",
                    UserId = "622d93dd-682c-4370-999b-6c4315ccceea"
                },

                new IdentityUserRole<string>()
                {
                    UserId = "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                    RoleId = "3"
                },

                new IdentityUserRole<string>()
                {
                    UserId = "08cfa46f-f2e4-4ae3-b3b7-6a99ee51843a",
                    RoleId = "2"
                },

                new IdentityUserRole<string>()
                {
                    UserId = "1a3c1aad-89c2-444f-88ef-ce265a341270",
                    RoleId = "2"
                }
            };

            return UsersRoles;

        }
            
    }
}
