using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEvents.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage ="Your event needs a name!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage ="Name must be between 3 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Your event needs a description!")]
        [StringLength(500, ErrorMessage ="Description is limited to 500 characters.")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

    }
}

