using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Messages
{
    public class MessageModel
    {
        public int Id { get; set; }

        public DateTime? DateAndTime { get; set; } = DateTime.Now;

        public string AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public AppUser Author { get; set; }

        [Required]
        public MessageCondition Condition { get; set; }

        [Required]
        public string Description { get; set; }

        public string FilePath { get; set; }
    }
}
