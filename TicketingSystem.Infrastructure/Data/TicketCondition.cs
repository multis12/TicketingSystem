using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Infrastructure.Data
{
    public class TicketCondition
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
