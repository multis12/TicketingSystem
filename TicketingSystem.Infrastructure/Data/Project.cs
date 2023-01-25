using System.ComponentModel.DataAnnotations;

namespace TicketingSystem.Infrastructure.Data
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public bool IsActive { get; set; } = true;
    }
}
