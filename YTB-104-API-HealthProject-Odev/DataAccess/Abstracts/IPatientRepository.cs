using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;

public interface IPatientRepository
{

    void Add(Patient patient);
    void Update(Patient patient);
    void Delete(Patient patient);

    List<Patient> GetAll();
    
    Patient GetById(int id);
    Patient GetByNameSurname(string nameSurname);
}
