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
                    UserId = "fe738829-bae4-46ec-a545-ed40aee912ea"
                },

                new IdentityUserRole<string>()
                {
                    RoleId = "2",
                    UserId = "fe738829-bae4-46ec-a545-ed40aee912ea"
                },

                new IdentityUserRole<string>()
                {
                    RoleId = "3",
                    UserId = "fe738829-bae4-46ec-a545-ed40aee912ea"
                },

                new IdentityUserRole<string>()
                {
                    UserId = "a02a086f-e7a3-4dba-9732-d92a137c1158",
                    RoleId = "3"
                },

                new IdentityUserRole<string>()
                {
                    UserId = "a02a086f-e7a3-4dba-9732-d92a137c1158",
                    RoleId = "2"
                },

                new IdentityUserRole<string>()
                {
                    UserId = "e7fc219d-b7ae-447e-ad73-1a6b4dc9c5e2",
                    RoleId = "2"
                }
            };

            return UsersRoles;

        }
            
    }
}
