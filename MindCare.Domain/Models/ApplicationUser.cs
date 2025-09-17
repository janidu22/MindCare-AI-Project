using Microsoft.AspNetCore.Identity;

namespace MindCare.Domain.Models;

public class ApplicationUser : IdentityUser
{
    public string DisplayName { get; set; } = string.Empty;
    public string? Bio { get; set; }
    public string? AvatarUrl { get; set; }
    public bool IsCounselorApproved { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public ICollection<Conversation> PatientConversations { get; set; } = new List<Conversation>();
    public ICollection<Conversation> CounselorConversations { get; set; } = new List<Conversation>();
    public ICollection<Message> Messages { get; set; } = new List<Message>();
    public ICollection<PeerGroupUser> PeerGroups { get; set; } = new List<PeerGroupUser>();
}
