namespace MindCare.Domain.Models;

public class Conversation
{
    public Guid Id { get; set; }
    public string PatientId { get; set; } = default!;
    public string CounselorId { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? ClosedAt { get; set; }

    // Navigation
    public ApplicationUser Patient { get; set; } = default!;
    public ApplicationUser Counselor { get; set; } = default!;
    public ICollection<Message> Messages { get; set; } = new List<Message>();
}
