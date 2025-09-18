using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baranggay_health_app.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set; } // Unique identifier for the doctor
        public string FirstName { get; set; } // First name of the doctor
        public string LastName { get; set; } // Last name of the doctor
        public string Specialization { get; set; } // Doctor's area of expertise (e.g., Cardiologist, Neurologist)
        public string ContactNumber { get; set; } // Contact number of the doctor
        public string Email { get; set; } // Email of the doctor
        public string Location { get; set; } // Doctor's office location or hospital
        public string Gender { get; set; } // Gender of the doctor

        // Navigation property for related patients
        public ICollection<Patient> Patients { get; set; } // One-to-many relationship: Doctor has many patients
    }
}
