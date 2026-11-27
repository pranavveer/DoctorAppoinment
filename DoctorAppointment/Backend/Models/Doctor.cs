using DoctorAppointment.Api.Enums;

namespace DoctorAppointment.Api.Models;

public class Doctor
{
    public int Id { get; set; }

    public string UserId { get; set; } = string.Empty;
    public ApplicationUser User { get; set; } = null!;

    public int SpecializationId { get; set; }
    public Specialization Specialization { get; set; } = null!;

    public string Qualification { get; set; } = string.Empty;

    public int ExperienceYears { get; set; }

    public decimal ConsultationFee { get; set; }

    public ConsultationMode ConsultationMode { get; set; }

    public bool IsAvailable { get; set; }

    public ICollection<DoctorAvailability> Availabilities { get; set; }
        = new List<DoctorAvailability>();
}