using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baranggay_health_app.Entities
{
    public class User
    {
        public int Id { get; set; } // Unique identifier for the user
        public string FirstName { get; set; } // First name of the user
        public string MiddleName { get; set; } // Middle name of the user (optional)
        public string LastName { get; set; } // Last name of the user
        public int Age { get; set; } // Age of the user
        public DateTime DateOfBirth { get; set; } // Date of birth of the user
        public string ContactNumber { get; set; } // Contact number of the user
        public string Location { get; set; } // Location of the user (could be address or city)
        public string Username { get; set; } // Username for login
        public string Password { get; set; } // Password for authentication
        public string Email { get; set; } // Email address of the user
        public byte[] Photo { get; set; } // Photo of the user (stored as a byte array)
        public string Gender { get; set; } // Gender of the user

    }
}
