namespace YTB_104_API_HealthProject_Odev.Models.Dtos.Appointments;

public class AppointmentAddRequestDto
{

    //public int AppointmentDay { get; set; }
    //public int AppointmentMonth { get; set; }
    //public int AppointmentYear { get; set; }


    public DateTime? AppointmentDate { get; set; }

    public string? Notes { get; set; } = "";
}
