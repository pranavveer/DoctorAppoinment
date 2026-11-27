namespace DoctorAppointment.Api.Models;

public class Specialization
{
    public int SpecializationId { get; set; }

    public string SpecializationName { get; set; } = string.Empty;

    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;

    // Navigation Property
    public ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();
}