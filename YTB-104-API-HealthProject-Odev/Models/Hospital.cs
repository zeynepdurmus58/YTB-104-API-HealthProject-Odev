using MongoDB.Bson.Serialization.Attributes;

namespace YTB_104_API_HealthProject_Odev.Models;

public class Hospital
{

    [BsonId]
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Adress { get; set; }
    public string? City { get; set; }

    public List<Doctor>? Doctors { get; set; }
}
