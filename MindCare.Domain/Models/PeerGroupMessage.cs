namespace MindCare.Domain.Models;

public class PeerGroupMessage
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public string SenderId { get; set; } = default!;
    public string Content { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public RiskLevel RiskLevel { get; set; } = RiskLevel.Normal;
    public double? RiskScore { get; set; }

    public PeerSupportGroup Group { get; set; } = default!;
    public ApplicationUser Sender { get; set; } = default!;
}
