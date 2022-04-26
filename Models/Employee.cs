using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace CodeFirst.Models
{
    public class Employee
    {
        // Primary key-Auto-incremented
        public int Id { get; set; }
        [Required]
        [StringLength(6)]
        [MinLength(6, ErrorMessage = "Employee code should be 6 Character.  Ex: M100654")]
        public string Code { get; set; }


        [StringLength(32)]
        [MinLength(2, ErrorMessage = "First name should be 2 to 32 characters")]
        [Display(Name = "First Name")]
        public string FirsttName { get; set; }


        [StringLength(32)]
        [MinLength(2, ErrorMessage = "Last name should be 2 to 32 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        
        [NotMapped]
        public string Fullname
        {
            get
            {
                return FirsttName +" "+ LastName;
            }
        }
        //complex Type

        //public Address Address;


        [Display(Name = "Date of joining")]
        [DataType(DataType.Date),
        DisplayFormat(DataFormatString ="{0:dd/mm/yyyy}",
            ApplyFormatInEditMode = true)]
        public DateTime? DOJ { get; set; }


        [Required]
        [Phone]
        [RegularExpression(@"\d{10}", ErrorMessage = "10 digits numbers only - Example: 9512341234")]
        [StringLength(10)]
        //[MinLength(10, ErrorMessage = "Mobile Phone should be in 10 digits 1234567890 format")]
        public string Mobile { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(128)]
        //[MinLength(128, ErrorMessage = "Email Phone should be in raj @mail.com format")]
          public string Email { get; set; }
        [DisplayFormat(NullDisplayText = "No Department")]
        [Display(Name = "Department")]
        public int? DepartmentId { get; set; }
        [Display(Name = "Department")]
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

    }
}
