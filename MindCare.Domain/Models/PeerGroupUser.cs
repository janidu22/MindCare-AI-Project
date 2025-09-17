namespace MindCare.Domain.Models;

public class PeerGroupUser
{
    public Guid Id { get; set; }
    public Guid GroupId { get; set; }
    public string UserId { get; set; } = default!;
    public string RoleInGroup { get; set; } = "Member"; // Member or Moderator
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

    public PeerSupportGroup Group { get; set; } = default!;
    public ApplicationUser User { get; set; } = default!;
}
