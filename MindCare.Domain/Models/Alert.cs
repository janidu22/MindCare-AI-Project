namespace MindCare.Domain.Models;

public class Alert
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = default!;
    public string RelatedEntityType { get; set; } = string.Empty;
    public string RelatedEntityId { get; set; } = string.Empty;
    public string Level { get; set; } = "Warning"; // Warning or Critical
    public string Message { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string DispatchedChannels { get; set; } = string.Empty; // email;sms

    public ApplicationUser User { get; set; } = default!;
}
