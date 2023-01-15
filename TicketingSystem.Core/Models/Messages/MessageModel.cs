using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Infrastructure.Data;
using TicketingSystem.Core.Models.Tickets;
using Microsoft.AspNetCore.Http;

namespace TicketingSystem.Core.Models.Messages
{
    public class MessageModel
    {
        public int Id { get; set; }

        public DateTime? DateAndTime { get; set; } = DateTime.Now;

        public string? AuthorId { get; set; }

        [Display(Name = "Condition")]
        public int ConditionId { get; set; }

        public IEnumerable<MessageConditionModel> Conditions { get; set; } = new List<MessageConditionModel>();

        [Required]
        [StringLength(3000)]
        public string Description { get; set; }

        public IFormFile? FilePath { get; set; }
    }
}
