using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;

public interface IAppointmentRepository
{

    void Add(Appointment appointment);
    void Update(Appointment appointment);
    void Delete(Appointment appointment);

    Appointment? GetById(int id);
    List<Appointment> GetAll();
}
