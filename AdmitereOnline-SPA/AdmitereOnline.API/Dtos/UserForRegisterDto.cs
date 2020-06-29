using System.ComponentModel.DataAnnotations;

namespace AdmitereOnline.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Parola trebuie sa contina intre 4 si 8 caractere")]

        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string emailAddress  { get; set; }

        [Required]
        public string CNP { get; set; }

        [Required]
        public string PhoneNo { get; set; }
        
    }
}