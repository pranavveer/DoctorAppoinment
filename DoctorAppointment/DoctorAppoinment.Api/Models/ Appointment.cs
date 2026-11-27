using DoctorAppointment.Api.Enums;

namespace DoctorAppointment.Api.Models;

public class Appointment
{
    public int Id { get; set; }

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; } = null!;

    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;

    public DateOnly Date { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public ConsultationMode ConsultationMode { get; set; }

    public AppointmentStatus Status { get; set; }
        = AppointmentStatus.Pending;

    public string? Reason { get; set; }

    public string? MeetingLink { get; set; }

    public string? ClinicAddress { get; set; }

    public DateTime CreatedAtUtc { get; set; }
        = DateTime.UtcNow;
}