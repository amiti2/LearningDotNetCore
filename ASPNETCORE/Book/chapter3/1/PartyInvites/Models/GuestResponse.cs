using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter valid name")]
        public string Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage ="Please enter you email address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Please enter your Phone number")]
        public string PhoneNumber { get; set; }
        
        [Required(ErrorMessage ="Please specify Whether you will attend")]
        public bool? WillAttend { get; set; }
    }
}
