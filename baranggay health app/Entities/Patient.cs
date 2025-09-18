using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baranggay_health_app.Entities
{
    public class Patient
    {
        public int PatientId { get; set; } // Unique identifier for the patient
        public string PatientName { get; set; } // Name of the patient
        public DateTime BirthDate { get; set; } // Patient's birth date
        public int Age { get; set; } // Patient's age (this could be calculated from BirthDate)
        public string Sex { get; set; } // Gender of the patient
        public string Purpose { get; set; } // Purpose of the appointment
        public DateTime Schedule { get; set; } // Scheduled appointment time
        public string Guardian { get; set; } // Guardian's name if applicable
        public string ContactNumber { get; set; } // Contact number of the patient or guardian
        public string Address { get; set; } // Patient's address

        // Foreign key to associate the patient with a specific doctor
        public int DoctorId { get; set; } // The ID of the doctor this patient is assigned to
        public Doctor Doctor { get; set; } // Navigation property to the doctor the patient belongs to
    }
}
