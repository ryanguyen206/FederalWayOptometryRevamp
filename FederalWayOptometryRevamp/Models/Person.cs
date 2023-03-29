using System.ComponentModel.DataAnnotations;

namespace FederalWayOptometryRevamp.Models
{
    //DESKTOP-5H6NALV\SQLEXPRESS
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]

        public string Address { get; set; }
       
        [Required]
        public int Phone { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
