namespace MindCare.Domain.Models;

public class PeerSupportGroup
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string CreatedById { get; set; } = default!;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ApplicationUser CreatedBy { get; set; } = default!;
    public ICollection<PeerGroupUser> Members { get; set; } = new List<PeerGroupUser>();
    public ICollection<PeerGroupMessage> Messages { get; set; } = new List<PeerGroupMessage>();
}
