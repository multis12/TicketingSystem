using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Infrastructure.Data.Configuration
{
    internal class AccountRequestRoleConfiguration : IEntityTypeConfiguration<AccountRequestRole>
    {
        public void Configure(EntityTypeBuilder<AccountRequestRole> builder)
        {
            builder.HasData(CreateAccountRequestRoles());
        }

        private List<AccountRequestRole> CreateAccountRequestRoles()
        {
            var accountRequestRoles = new List<AccountRequestRole>()
            { 
                new AccountRequestRole()
                {
                    Id = 1,
                    Name = "Administrator"
                },

                new AccountRequestRole()
                {
                    Id = 2,
                    Name = "Client"
                },

                new AccountRequestRole()
                {
                    Id = 3,
                    Name = "Staff"
                },
            };

            return accountRequestRoles;
        }

    }
}
