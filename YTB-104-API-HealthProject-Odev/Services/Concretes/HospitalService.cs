using YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;
using YTB_104_API_HealthProject_Odev.Models;
using YTB_104_API_HealthProject_Odev.Models.Dtos.Hospitals;
using YTB_104_API_HealthProject_Odev.Services.Abstracts;

namespace YTB_104_API_HealthProject_Odev.Services.Concretes;

public class HospitalService : IHospitalService
{

    private IHospitalRepository _hospitalRepository;

    public HospitalService(IHospitalRepository hospitalRepository)
    {
        _hospitalRepository = hospitalRepository;
    }

    public void Add(HospitalAddRequestDto hospitalAddRequestDto)
    {
        Hospital hospital = ConvertToHospital(hospitalAddRequestDto);
        _hospitalRepository.Add(hospital);
    }

    public List<HospitalResponseDto> GetAll()
    {
        List<Hospital> hospitals = _hospitalRepository.GetAll();
        List<HospitalResponseDto> responses = ConvertToResponseDtoList(hospitals);

        return responses;
    }

    public HospitalResponseDto? GetById(string id)
    {
        Guid convertId = new Guid(id);

        Hospital hospital = _hospitalRepository.GetById(convertId);
        HospitalResponseDto responses = ConvertToResponseDto(hospital);
        return responses;
    }

    private Hospital ConvertToHospital(HospitalAddRequestDto dto)
    {
        return new Hospital { Name = dto.Name, Adress = dto.Adress, City = dto.City };
    }

    private HospitalResponseDto ConvertToResponseDto(Hospital hospital)
    {
        return new HospitalResponseDto()
        {
            Id = hospital.Id.ToString(),
            Adress = hospital.Adress,
            City = hospital.City,
        };
    }

    private List<HospitalResponseDto> ConvertToResponseDtoList(List<Hospital> hospitals)
    {
        throw new NotImplementedException();
    }
}
