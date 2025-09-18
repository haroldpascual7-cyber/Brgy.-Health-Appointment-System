using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baranggay_health_app.Entities
{
   public class Appointment
    {
        public int IdApp { get; set; } // Unique identifier for the appointment
        public string PatientName { get; set; } // Name of the patient
        public DateTime BirthDate { get; set; } // Birthdate of the patient
        public int Age { get; set; } // Age of the patient
        public string Sex { get; set; } // Gender of the patient
        public string Purpose { get; set; } // Purpose of the appointment
        public string Doctor { get; set; } // Name of the doctor
        public DateTime Schedule { get; set; } // Appointment schedule date/time
        public string Guardian { get; set; } // Guardian name (if applicable)
        public string ContactNumber { get; set; } // Contact number of the patient or guardian
        public string Address { get; set; } // Address of the patient
    }
}
