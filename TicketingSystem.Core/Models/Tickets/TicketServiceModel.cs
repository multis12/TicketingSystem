using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Tickets
{
    public class TicketServiceModel
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public IFormFile? FilePath { get; set; }

        public DateTime DateAndTime { get; set; } = DateTime.Now;

        public string? FirstName { get; set; }

        public string? SecondName { get; set; }

        public string? Email { get; set; }

        public string? Type { get; set; }

        public string? Condition { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
