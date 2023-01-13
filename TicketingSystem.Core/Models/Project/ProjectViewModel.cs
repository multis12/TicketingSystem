using System.ComponentModel.DataAnnotations;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Project
{
    public class ProjectViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
