using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketingSystem.Infrastructure.Data
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        public DateTime? DateAndTime { get; set; }

        public string AuthorId  { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public AppUser Author { get; set; }

        public int ConditionId { get; set; }

        [ForeignKey(nameof(ConditionId))]
        public MessageCondition Condition { get; set; }

        [Required]
        public string Description { get; set; }

        public string? FilePath { get; set; }
    }
}
