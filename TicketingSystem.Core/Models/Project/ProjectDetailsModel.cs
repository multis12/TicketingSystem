using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Core.Models.Tickets;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Project
{
    public class ProjectDetailsModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<TicketServiceModel> Tickets { get; set; } = new List<TicketServiceModel>();
    }
}
