
using Microsoft.EntityFrameworkCore;
using NewClinicWebsite.Models;

public class AppointmentDbContext : DbContext
{
    public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options)
        : base(options)
    {
    }

    public DbSet<AppointmentForm> Appointments { get; set; }
}