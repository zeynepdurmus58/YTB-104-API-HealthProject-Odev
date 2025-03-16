
using YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;
using YTB_104_API_HealthProject_Odev.DataAccess.Contexts;
using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Concretes;

public class PatientRepository : IPatientRepository
{

    private BaseDbContext context;

    public PatientRepository(BaseDbContext context)
    {
        this.context = context;
    }

    public void Add(Patient patient)
    {
        context.Patients.Add(patient);
        context.SaveChanges();
    }

    public void Delete(Patient patient)
    {
        context.Patients.Remove(patient);
        context.SaveChanges();
    }

    public List<Patient> GetAll()
    {
        List<Patient> patients = context.Patients.ToList();
        return patients;
    }

    public Patient GetById(int id)
    {
        return context.Patients.Find(id);
    }

    public Patient GetByNameSurname(string nameSurname)
    {
        throw new NotImplementedException();
    }

    public void Update(Patient patient)
    {
        context.Patients.Update(patient);
        context.SaveChanges();
    }
}
