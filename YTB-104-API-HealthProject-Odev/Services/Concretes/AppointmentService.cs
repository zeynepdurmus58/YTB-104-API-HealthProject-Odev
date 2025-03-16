using YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;
using YTB_104_API_HealthProject_Odev.Models;
using YTB_104_API_HealthProject_Odev.Models.Dtos.Appointments;
using YTB_104_API_HealthProject_Odev.Services.Abstracts;

namespace YTB_104_API_HealthProject_Odev.Services.Concretes;

public class AppointmentService : IAppointmentService
{

    private IAppointmentRepository appointmentRepository;
    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        this.appointmentRepository = appointmentRepository;
    }

    public void Add(AppointmentAddRequestDto appointmentAddRequestDto)
    {
        Appointment appointment = ConvertToAppointment(appointmentAddRequestDto);
        appointmentRepository.Add(appointment);
    }


    public void Delete(int id)
    {
        Appointment appointment = appointmentRepository.GetById(id);
        appointmentRepository.Delete(appointment);
    }

    public List<AppointmentResponseDto> GetAll()
    {
        List<Appointment> appointments = appointmentRepository.GetAll();
        List<AppointmentResponseDto> responses = ConvertToResponseDtoList(appointments);
        return responses;
    }

    public AppointmentResponseDto? GetById(int id)
    {
        Appointment appointment = appointmentRepository.GetById(id);
        AppointmentResponseDto response = ConvertToResponseDto(appointment);
        return response;
    }
    private List<AppointmentResponseDto> ConvertToResponseDtoList(List<Appointment> appointments)
    {
        return appointments.Select(x => ConvertToResponseDto(x)).ToList();
    }
    private AppointmentResponseDto ConvertToResponseDto(Appointment appointment)
    {
        return new AppointmentResponseDto
        {
            Id = appointment.Id,
            DoctorId = appointment.DoctorId,
            AppointmentDate = appointment.AppointmentDate,
            Notes = appointment.Notes
        };
    }


    private Appointment ConvertToAppointment(AppointmentAddRequestDto dto)
    {
        return new Appointment { AppointmentDate = dto.AppointmentDate };
    }

}