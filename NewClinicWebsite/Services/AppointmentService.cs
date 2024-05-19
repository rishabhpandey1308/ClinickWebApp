using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewClinicWebsite.Models;


public class AppointmentService
{
    private readonly AppointmentDbContext _context;

    public AppointmentService(AppointmentDbContext context)
    {
        _context = context;
    }

    public async Task AddAppointmentAsync(AppointmentForm appointment)
    {
        _context.Appointments.Add(appointment);
        await _context.SaveChangesAsync();
    }
}