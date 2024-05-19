using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewClinicWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewClinicWebsite.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Appointment()
        {
            return View();
        }

        private readonly AppointmentService _appointmentService;

        public AppointmentController(AppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [HttpPost]
        public async Task<IActionResult> BookAppointment(AppointmentForm appointment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _appointmentService.AddAppointmentAsync(appointment);
                return Ok();
            }
            catch (DbUpdateException ex)
            {
                // Log the outer exception
                Console.WriteLine($"Outer Exception: {ex.Message}");

                // If there is an inner exception, log its details
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                return Ok();
            }
        }
    }
}
