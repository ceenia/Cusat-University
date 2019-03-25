using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cusat_University.Models
{
    public abstract class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last name length must be between 3 and 50.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "First name length must be between 3 and 50.")]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + " , " + FirstMidName;
            }
        }
    }
}