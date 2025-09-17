namespace MindCare.Domain.Models;

public enum RiskLevel
{
    Normal = 0,
    Warning = 1,
    Critical = 2
}

public class Message
{
    public Guid Id { get; set; }
    public Guid ConversationId { get; set; }
    public string SenderId { get; set; } = default!;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // AI Analysis
    public RiskLevel RiskLevel { get; set; } = RiskLevel.Normal;
    public double? RiskScore { get; set; }
    public DateTime? AnalyzedAt { get; set; }

    // Navigation
    public Conversation Conversation { get; set; } = default!;
    public ApplicationUser Sender { get; set; } = default!;
}
