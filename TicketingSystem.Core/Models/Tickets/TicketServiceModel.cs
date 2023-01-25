using TicketingSystem.Infrastructure.Data;

namespace TicketingSystem.Core.Models.Tickets
{
    public class TicketServiceModel
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public string? FilePath { get; set; }

        public DateTime? DateAndTime { get; set; }

        public string? FirstName { get; set; }

        public string? SecondName { get; set; }

        public string? Email { get; set; }

        public string? Type { get; set; }

        public string? Condition { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
    }
}
