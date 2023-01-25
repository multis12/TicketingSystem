using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Infrastructure.Data
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
