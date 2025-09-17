using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MindCare.Domain.Models;

namespace MindCare.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Conversation> Conversations { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<PeerSupportGroup> PeerSupportGroups { get; set; }
    public DbSet<PeerGroupUser> PeerGroupUsers { get; set; }
    public DbSet<PeerGroupMessage> PeerGroupMessages { get; set; }
    public DbSet<Alert> Alerts { get; set; }
    public DbSet<CredentialVerificationLog> CredentialVerificationLogs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Conversation relationships
        builder.Entity<Conversation>()
            .HasOne(c => c.Patient)
            .WithMany(u => u.PatientConversations)
            .HasForeignKey(c => c.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Conversation>()
            .HasOne(c => c.Counselor)
            .WithMany(u => u.CounselorConversations)
            .HasForeignKey(c => c.CounselorId)
            .OnDelete(DeleteBehavior.Restrict);

        // Message relationships
        builder.Entity<Message>()
            .HasOne(m => m.Conversation)
            .WithMany(c => c.Messages)
            .HasForeignKey(m => m.ConversationId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Message>()
            .HasOne(m => m.Sender)
            .WithMany(u => u.Messages)
            .HasForeignKey(m => m.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        // Appointment relationships
        builder.Entity<Appointment>()
            .HasOne(a => a.Patient)
            .WithMany()
            .HasForeignKey(a => a.PatientId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Appointment>()
            .HasOne(a => a.Counselor)
            .WithMany()
            .HasForeignKey(a => a.CounselorId)
            .OnDelete(DeleteBehavior.Restrict);

        // PeerSupportGroup
        builder.Entity<PeerSupportGroup>()
            .HasOne(g => g.CreatedBy)
            .WithMany()
            .HasForeignKey(g => g.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);

        // PeerGroupUser
        builder.Entity<PeerGroupUser>()
            .HasOne(pgu => pgu.Group)
            .WithMany(g => g.Members)
            .HasForeignKey(pgu => pgu.GroupId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PeerGroupUser>()
            .HasOne(pgu => pgu.User)
            .WithMany(u => u.PeerGroups)
            .HasForeignKey(pgu => pgu.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PeerGroupUser>()
            .HasIndex(p => new { p.GroupId, p.UserId })
            .IsUnique();

        // PeerGroupMessage
        builder.Entity<PeerGroupMessage>()
            .HasOne(pg => pg.Group)
            .WithMany(g => g.Messages)
            .HasForeignKey(pg => pg.GroupId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<PeerGroupMessage>()
            .HasOne(pg => pg.Sender)
            .WithMany()
            .HasForeignKey(pg => pg.SenderId)
            .OnDelete(DeleteBehavior.Restrict);

        // Alert
        builder.Entity<Alert>()
            .HasOne(a => a.User)
            .WithMany()
            .HasForeignKey(a => a.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        // CredentialVerificationLog
        builder.Entity<CredentialVerificationLog>()
            .HasOne(cvl => cvl.Counselor)
            .WithMany()
            .HasForeignKey(cvl => cvl.CounselorId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<CredentialVerificationLog>()
            .HasOne(cvl => cvl.ReviewedByAdmin)
            .WithMany()
            .HasForeignKey(cvl => cvl.ReviewedByAdminId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
