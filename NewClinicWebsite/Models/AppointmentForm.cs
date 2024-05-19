using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewClinicWebsite.Models
{
    public class AppointmentForm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Doctor { get; set; }
        [Column("AppointmentDate")]
        public DateTime AppointmentDate { get; set; }

        [Column("AppointmentTime")]
        public DateTime AppointmentTime { get; set; }
        public string ProblemDescription { get; set; }
    }
}
