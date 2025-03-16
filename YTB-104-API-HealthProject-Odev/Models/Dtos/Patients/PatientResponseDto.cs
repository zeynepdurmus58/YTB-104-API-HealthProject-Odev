namespace YTB_104_API_HealthProject_Odev.Models.Dtos.Patients;

public class PatientResponseDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public int BirthDay { get; set; }
    public int BirthMonth { get; set; }
    public int BirthYear { get; set; }
}
