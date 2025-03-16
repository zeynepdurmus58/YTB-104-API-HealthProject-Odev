namespace YTB_104_API_HealthProject_Odev.Models;

public class Patient
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? Surname { get; set; }
    public DateTime BirthDate { get; set; }

    public List<Appointment> Appointments { get; set; }
}
