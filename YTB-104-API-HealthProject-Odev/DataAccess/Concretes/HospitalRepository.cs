using YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;
using YTB_104_API_HealthProject_Odev.DataAccess.Contexts;
using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Concretes;

public class HospitalRepository : IHospitalRepository
{

    private MongoDbContext context;

    public HospitalRepository(MongoDbContext context)
    {
        this.context = context;
    }
    public void Add(Hospital hospital)
    {
        context.Add(hospital);
        context.SaveChanges();
    }

    public void Delete(Hospital hospital)
    {
        context.Remove(hospital);
        context.SaveChanges();
    }

    public List<Hospital> GetAll()
    {
        return context.Hospitals.ToList();
    }

    public Hospital GetById(Guid id)
    {
        return context.Hospitals.Find(id);
    }
}
