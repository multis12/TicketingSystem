using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Infrastructure.Data.Configuration
{
    internal class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.HasData(CreateTypes());
        }

        private List<Type> CreateTypes()
        {
            var types = new List<Type>();

            var type = new Type()
            {
                Id = 1,
                Name= "Bug report"
            };
            types.Add(type);

            type = new Type()
            {
                Id = 2,
                Name = "Feature request"
            };

            types.Add(type);

            type = new Type()
            {
                Id = 3,
                Name = "Assistance request"
            };

            types.Add(type);

            type = new Type()
            {
                Id = 4,
                Name = "Other"
            };

            types.Add(type);

            return types;
        }
    }
}
