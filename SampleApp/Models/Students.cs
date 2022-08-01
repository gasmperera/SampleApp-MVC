using System;
using System.ComponentModel.DataAnnotations;

namespace SampleApp.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Enter first name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage ="Enter nast name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter mobile number")]
        [Display(Name = "Mobile Number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Enter email address")]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter NIC number")]
        [Display(Name = "NIC Number")]
        public string NIC { get; set; }

        [Required(ErrorMessage = "Enter date of birth")]
        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}
