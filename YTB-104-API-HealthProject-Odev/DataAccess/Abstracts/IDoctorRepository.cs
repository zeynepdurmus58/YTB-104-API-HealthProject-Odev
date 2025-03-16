using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;

public interface IDoctorRepository
{

    void Add(Doctor doctor);
    void Update(Doctor doctor);
    void Delete(int id);

    List<Doctor> GetAll();

    Doctor? GetById(int id);
}
