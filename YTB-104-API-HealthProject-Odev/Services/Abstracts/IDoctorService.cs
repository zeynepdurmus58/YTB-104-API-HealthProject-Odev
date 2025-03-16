using YTB_104_API_HealthProject_Odev.Models.Dtos.Doctors;

namespace YTB_104_API_HealthProject_Odev.Services.Abstracts;

public interface IDoctorService
{
    void Add(DoctorAddRequestDto doctorAddRequestDto);

    void Delete(int id);

    List<DoctorResponseDto>? GetAll();
    DoctorResponseDto GetById(int id);
}
