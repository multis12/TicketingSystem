using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Infrastructure.Data.Configuration
{
    internal class TicketConditionConfiguration : IEntityTypeConfiguration<TicketCondition>
    {
        public void Configure(EntityTypeBuilder<TicketCondition> builder)
        {
            builder.HasData(CreateConditions());
        }

        private List<TicketCondition> CreateConditions()
        {
            var conditions = new List<TicketCondition>();

            var condition = new TicketCondition()
            {
                Id = 1,
                Name = "Чернова"
            };
            conditions.Add(condition);

            condition = new TicketCondition()
            {
                Id = 2,
                Name = "Нов"
            };
            conditions.Add(condition);

            condition = new TicketCondition()
            {
                Id = 3,
                Name = "Работи се"
            };
            conditions.Add(condition);

            condition = new TicketCondition()
            {
                Id = 4,
                Name = "Приключен"
            };
            conditions.Add(condition);

            return conditions;
        }

    }
}
