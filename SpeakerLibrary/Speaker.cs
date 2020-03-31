using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpeakerLibrary
{
    class Speaker
    {
        public string SpeakerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Specialization { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Employer { get; set; }

    }
}
