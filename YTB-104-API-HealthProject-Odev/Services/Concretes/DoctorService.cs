using YTB_104_API_HealthProject_Odev.DataAccess.Abstracts;
using YTB_104_API_HealthProject_Odev.Models;
using YTB_104_API_HealthProject_Odev.Models.Dtos.Doctors;
using YTB_104_API_HealthProject_Odev.Services.Abstracts;

namespace YTB_104_API_HealthProject_Odev.Services.Concretes;

public class DoctorService : IDoctorService
{

    private IDoctorRepository doctorRepository;

    public DoctorService(IDoctorRepository doctorRepository)
    {
        this.doctorRepository = doctorRepository;
    }

    public void Add(DoctorAddRequestDto doctorAddRequestDto)
    {
        Doctor doctor = ConvertToDoctor(doctorAddRequestDto);
        doctorRepository.Add(doctor);
    }

   

    public List<DoctorResponseDto> GetAll()
    {
        List<Doctor> doctors = doctorRepository.GetAll();
        List<DoctorResponseDto> responses = ConvertToResponseDtoList(doctors);
        return responses;
    }

    public DoctorResponseDto GetById(int id)
    {
        Doctor doctor = doctorRepository.GetById(id);
        DoctorResponseDto response = ConvertToResponse(doctor);

        return response;
    }




    private Doctor ConvertToDoctor(DoctorAddRequestDto dto)
    {
        return new Doctor
        {
            FirstName = dto.FirstName,
            Surname = dto.Surname,
        };
    }


    private List<DoctorResponseDto> ConvertToResponseDtoList(List<Doctor> doctors)
    {
        return doctors.Select(x => ConvertToResponse(x)).ToList();
    }


    private DoctorResponseDto ConvertToResponse(Doctor doctor)
    {
        return new DoctorResponseDto
        {
            Id = doctor.Id,
            FirstName = doctor.FirstName,
            Surname = doctor.Surname
        };
    }

    public void Delete(int id)
    {

        //Doctor doctor = doctorRepository.GetById(id);
        //doctorRepository.Delete(id);
        throw new NotImplementedException();
    }
}
