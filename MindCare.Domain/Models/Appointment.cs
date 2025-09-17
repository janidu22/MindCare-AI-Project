namespace MindCare.Domain.Models;

public enum AppointmentStatus
{
    Pending,
    Confirmed,
    Completed,
    Cancelled
}

public class Appointment
{
    public Guid Id { get; set; }
    public string PatientId { get; set; } = default!;
    public string CounselorId { get; set; } = default!;
    public DateTime StartsAt { get; set; }
    public DateTime EndsAt { get; set; }
    public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;
    public string? Notes { get; set; }
    public string? VideoRoomId { get; set; }

    public ApplicationUser Patient { get; set; } = default!;
    public ApplicationUser Counselor { get; set; } = default!;
}
