using System.ComponentModel.DataAnnotations;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Project
{
    public class ProjectModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        [Required]
        [StringLength(2000)]
        public string? Description { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
