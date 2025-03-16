using Microsoft.AspNetCore.Mvc;
using YTB_104_API_HealthProject_Odev.Models.Dtos.Patients;
using YTB_104_API_HealthProject_Odev.Services.Abstracts;

namespace YTB_104_API_HealthProject_Odev.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private IPatientService patientService;

    public PatientsController(IPatientService patientService)
    {
        this.patientService = patientService;
    }


    [HttpPost("add")]
    public IActionResult Add(PatientAddRequestDto dto)
    {

        patientService.Add(dto);

        return Ok("Hasta Eklendi.");
    }



    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(patientService.GetAll());
    }

}
