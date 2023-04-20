using System.ComponentModel.DataAnnotations;

namespace PetSitter.ViewModels
{
    public class UserVM
    {
        // ASP.NET USER
        [Key]
        [Required]
        public string Email { get; set; }

    }
}