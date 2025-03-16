using YTB_104_API_HealthProject_Odev.Models.Dtos.Appointments;

namespace YTB_104_API_HealthProject_Odev.Services.Abstracts;

public interface IAppointmentService
{

    List<AppointmentResponseDto> GetAll();

    AppointmentResponseDto? GetById(int id);

    void Add(AppointmentAddRequestDto appointmentAddRequestDto);

    void Delete(int id);
}
