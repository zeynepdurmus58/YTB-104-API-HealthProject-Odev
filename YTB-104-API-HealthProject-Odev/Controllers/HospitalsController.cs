using Microsoft.AspNetCore.Mvc;
using YTB_104_API_HealthProject_Odev.Models.Dtos.Hospitals;
using YTB_104_API_HealthProject_Odev.Services.Abstracts;

namespace YTB_104_API_HealthProject_Odev.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HospitalsController : ControllerBase
{
    private IHospitalService _hospitalService;

    public HospitalsController(IHospitalService hospitalService)
    {
        _hospitalService = hospitalService;
    }


    [HttpPost("add")]
    public IActionResult Add(HospitalAddRequestDto hospital)
    {

        _hospitalService.Add(hospital);
        return Ok("Kullanıcı Eklendi.");
    }


    [HttpGet("getbyid")]
    public IActionResult GetById(string id)
    {

        HospitalResponseDto hospitalResponseDto = _hospitalService.GetById(id);
        return Ok(hospitalResponseDto);

    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<HospitalResponseDto> hospitals = _hospitalService.GetAll();

        return Ok(hospitals);
    }
}
