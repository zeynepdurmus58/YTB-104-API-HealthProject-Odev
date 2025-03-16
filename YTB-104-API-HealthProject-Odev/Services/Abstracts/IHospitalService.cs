using YTB_104_API_HealthProject_Odev.Models.Dtos.Hospitals;

namespace YTB_104_API_HealthProject_Odev.Services.Abstracts;

public interface IHospitalService
{
    List<HospitalResponseDto> GetAll();
    HospitalResponseDto? GetById(string id);
    void Add(HospitalAddRequestDto userAddRequestDto);
}
