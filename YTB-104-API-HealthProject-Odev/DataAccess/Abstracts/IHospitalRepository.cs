using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;

public interface IHospitalRepository
{
    void Add(Hospital hospital);

    List<Hospital> GetAll();

    Hospital GetById(Guid id);

    void Delete(Hospital hospital);
}
