using YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;
using YTB_104_API_HealthProject_Odev.DataAccess.Contexts;
using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Concretes;

public class AppointmentRepository : IAppointmentRepository
{

    private BaseDbContext context;

    public AppointmentRepository(BaseDbContext context)
    {
        this.context = context;
    }


    public void Add(Appointment appointment)
    {
        context.Add(appointment);
        context.SaveChanges();
    }

    public void Delete(Appointment appointment)
    {
        context.Remove(appointment);
        context.SaveChanges();
    }

    public List<Appointment> GetAll()
    {
        List<Appointment> appointments = context.Appointments.ToList();
        return appointments;
    }

    public Appointment? GetById(int id)
    {
        return context.Appointments.Find(id);
    }

    public void Update(Appointment appointment)
    {
        context.Appointments.Update(appointment);
        context.SaveChanges();
    }
}
