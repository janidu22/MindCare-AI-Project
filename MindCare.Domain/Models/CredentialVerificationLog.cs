namespace MindCare.Domain.Models;

public class CredentialVerificationLog
{
    public Guid Id { get; set; }
    public string CounselorId { get; set; } = default!;
    public string BlobUrl { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public string? OcrSummary { get; set; }
    public bool? IsValid { get; set; }
    public string? ReviewedByAdminId { get; set; }
    public DateTime? ReviewedAt { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ApplicationUser Counselor { get; set; } = default!;
    public ApplicationUser? ReviewedByAdmin { get; set; }
}
