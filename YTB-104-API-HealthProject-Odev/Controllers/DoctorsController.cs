using Microsoft.AspNetCore.Mvc;
using YTB_104_API_HealthProject_Odev.Models.Dtos.Doctors;
using YTB_104_API_HealthProject_Odev.Services.Abstracts;

namespace YTB_104_API_HealthProject_Odev.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorsController : ControllerBase
{

    private IDoctorService doctorService;

    public DoctorsController(IDoctorService doctorService)
    {
        this.doctorService = doctorService;
    }


    [HttpPost("add")]
    public IActionResult Add(DoctorAddRequestDto dto)
    {

        doctorService.Add(dto);

        return Ok("Doktor Eklendi.");
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(doctorService.GetAll());
    }

}
