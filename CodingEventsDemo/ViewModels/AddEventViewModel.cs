using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }

        [Range(0, 100000, ErrorMessage = "Maximum number of attendees is 100,000")]
        public int NumberOfAttendees { get; set; }

        public bool IsTrue { get { return true; } }

        [Required]
        [Compare("IsTrue", ErrorMessage = "Must be true.")]
        public bool RegistrationRequired { get; set; }


    }
}
