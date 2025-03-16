using YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;
using YTB_104_API_HealthProject_Odev.Models;
using YTB_104_API_HealthProject_Odev.Models.Dtos.Patients;
using YTB_104_API_HealthProject_Odev.Services.Abstracts;

namespace YTB_104_API_HealthProject_Odev.Services.Concretes;

public class PatientService : IPatientService
{

    private IPatientRepository patientRepository;

    public PatientService(IPatientRepository patientRepository)
    {
        this.patientRepository = patientRepository;
    }

    public void Add(PatientAddRequestDto patientAddRequestDto)
    {
        Patient patient = ConvertToPatient(patientAddRequestDto);
        patientRepository.Add(patient);
    }

    public void Delete(int id)
    {
        Patient patient = patientRepository.GetById(id);
        patientRepository.Delete(patient);
    }

    public List<PatientResponseDto> GetAll()
    {
        List<Patient> patients = patientRepository.GetAll();
        List<PatientResponseDto> responses = ConvertToResponseDtoList(patients);
        return responses;
    }

    public PatientResponseDto? GetById(int id)
    {
        Patient patient = patientRepository.GetById(id);
        PatientResponseDto response = ConvertToResponse(patient);

        return response;
    }



    private Patient ConvertToPatient(PatientAddRequestDto dto)
    {
        return new Patient
        {
            FirstName = dto.FirstName,
            Surname = dto.Surname,
            BirthDate = new DateTime(dto.BirthYear, dto.BirthMonth, dto.BirthDay),
        };
    }


    private List<PatientResponseDto> ConvertToResponseDtoList(List<Patient> patients)
    {
        return patients.Select(x => ConvertToResponse(x)).ToList();
    }


    private PatientResponseDto ConvertToResponse(Patient patient)
    {
        return new PatientResponseDto
        {
            Id = patient.Id,
            BirthDay = patient.BirthDate.Day,
            BirthMonth = patient.BirthDate.Month,
            BirthYear = patient.BirthDate.Year,
            FirstName = patient.FirstName,
            Surname = patient.Surname
        };
    }

}
