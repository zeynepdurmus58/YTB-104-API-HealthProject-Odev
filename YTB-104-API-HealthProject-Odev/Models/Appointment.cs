﻿namespace YTB_104_API_HealthProject_Odev.Models;

public class Appointment
{
    public int Id { get; set; }

    public int DoctorId { get; set; }
    public Doctor? Doctor { get; set; }

    public int PatientId { get; set; }
    public Patient? Patient { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public string? Notes { get; set; } = "";

}
