using System.ComponentModel.DataAnnotations;

namespace PetSitter.ViewModels
{
    public class UserRoleVM
    {
        // Assign role to user
        [Key]
        public int ID { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Role { get; set; }

    }
}