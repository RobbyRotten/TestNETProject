using System.ComponentModel.DataAnnotations;

namespace MyApp.Models
{
    public class Contact
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [StringLength(250)]
        public string Note { get; set; }
    }
}
