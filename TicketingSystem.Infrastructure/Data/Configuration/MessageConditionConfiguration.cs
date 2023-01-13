using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Infrastructure.Data.Configuration
{
    internal class MessageConditionConfiguration : IEntityTypeConfiguration<MessageCondition>
    {
        public void Configure(EntityTypeBuilder<MessageCondition> builder)
        {
            builder.HasData(CreateMessageConditions());
        }

        private List<MessageCondition> CreateMessageConditions()
        {
            List<MessageCondition> messageConditions = new List<MessageCondition>();

            var messageCondition = new MessageCondition()
            {
                Id = 1,
                Name = "Чернова"
            };
            messageConditions.Add(messageCondition);

            messageCondition = new MessageCondition()
            {
                Id=2,
                Name = "Публикувано"
            };

            return messageConditions;
        }
    }
}
