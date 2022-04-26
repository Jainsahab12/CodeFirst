using System.ComponentModel.DataAnnotations;
namespace CodeFirst.Models
{
    public class Department
    {
        //primary Key - Auton incremented
        public int Id { get; set; }

        [Required(ErrorMessage ="Department Name is Required!")]
        [StringLength(64, ErrorMessage ="Maximum of 64 characters")]
        [MinLength(2, ErrorMessage ="minimum of 2 Characters")]
        [Display(Name ="Department")]
        public string Name { get; set; }

    }
}
