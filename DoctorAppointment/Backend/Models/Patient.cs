namespace DoctorAppointment.Api.Models;

public class Patient
{
    public int Id { get; set; }

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }
}