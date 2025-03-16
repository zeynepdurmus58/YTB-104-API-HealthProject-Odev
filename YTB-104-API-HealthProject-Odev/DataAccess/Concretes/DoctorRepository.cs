using YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;
using YTB_104_API_HealthProject_Odev.DataAccess.Contexts;
using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Concretes;

public class DoctorRepository : IDoctorRepository
{
    private BaseDbContext context;

    public DoctorRepository(BaseDbContext context)
    {
        this.context = context;
    }

    public void Add(Doctor doctor)
    {
        context.Doctors.Add(doctor);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        context.Remove(id);
        context.SaveChanges();
    }


    public List<Doctor> GetAll()
    {
        List<Doctor> doctors = context.Doctors.ToList();
        return doctors;
    }

    public Doctor GetById(int id)
    {
        return context.Doctors.Find(id);
    }

    public void Update(Doctor doctor)
    {
        context.Doctors.Update(doctor);
        context.SaveChanges();
    }
}
