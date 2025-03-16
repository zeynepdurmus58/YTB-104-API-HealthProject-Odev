using YTB_104_API_HealthProject_Odev.Models.Dtos.Patients;

namespace YTB_104_API_HealthProject_Odev.Services.Abstracts;

public interface IPatientService
{
    void Add(PatientAddRequestDto patientAddRequestDto);

    List<PatientResponseDto> GetAll();

    PatientResponseDto? GetById(int id);

    void Delete(int id);
}
