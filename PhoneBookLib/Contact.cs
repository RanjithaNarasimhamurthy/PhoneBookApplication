using System.ComponentModel.DataAnnotations;

namespace PhoneBookLib
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        [RegularExpression(@"^(?:19|20)\d{2}-(?:(?:0[1-9]|1[0-2])-(?:0[1-9]|1\d|2[0-8])|(?:0[13-9]|1[0-2])-30|(?:0[13578]|1[02])-31)$", ErrorMessage = "Please enter a valid date of birth in the format YYYY-MM-DD.")]
        public string Dob { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Please enter a valid 10-digit phone number.")]
        public string Phone { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Picture { get; set; }
    }
}