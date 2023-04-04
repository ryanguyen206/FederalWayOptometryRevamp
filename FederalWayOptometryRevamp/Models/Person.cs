using System.ComponentModel.DataAnnotations;

namespace FederalWayOptometryRevamp.Models
{
    //DESKTOP-5H6NALV\SQLEXPRESS
    public class Person
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }
       
        [Required]
        public int Phone { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
