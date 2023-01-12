using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
