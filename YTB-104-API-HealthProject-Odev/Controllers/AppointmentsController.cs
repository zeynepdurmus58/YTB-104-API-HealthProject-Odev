using Microsoft.AspNetCore.Mvc;
using YTB_104_API_HealthProject_Odev.Models.Dtos.Appointments;
using YTB_104_API_HealthProject_Odev.Services.Abstracts;

namespace YTB_104_API_HealthProject_Odev.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AppointmentsController : ControllerBase
{
    private IAppointmentService appointmentService;

    public AppointmentsController(IAppointmentService appointmentService)
    {
        this.appointmentService = appointmentService;
    }


    [HttpPost("add")]
    public IActionResult Add(AppointmentAddRequestDto dto)
    {

        appointmentService.Add(dto);

        return Ok("Randevu Eklendi.");
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        return Ok(appointmentService.GetAll());
    }
}
