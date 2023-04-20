using System;
using System.Collections.Generic;

namespace PetSitter.Models
{
    public partial class PetSittersUser
    {
        public int UserId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PostalCode { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string StreetAddress { get; set; } = null!;
        public string City { get; set; } = null!;
    }
}
