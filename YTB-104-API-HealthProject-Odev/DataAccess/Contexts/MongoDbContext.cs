using Microsoft.EntityFrameworkCore;
using YTB_104_API_HealthProject_Odev.Models;

namespace YTB_104_API_HealthProject_Odev.DataAccess.Contexts;

public class MongoDbContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMongoDB("mongodb://localhost:27018", "HealthProject_hospital_db");
    }



    public DbSet<Hospital> Hospitals { get; set; }

}
