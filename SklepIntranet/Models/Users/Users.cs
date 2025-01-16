using System.ComponentModel.DataAnnotations;

namespace SklepIntranet.Models.Users
{
    public class Users
    {
        [Key]
        public int IdUsers { get; set; }

        [Display(Name = "Imię")]
        public string? UserName { get; set; }

        [Display(Name = "Nazwisko")]
        public string? UserSurname { get; set; }

        [Display(Name = "e-mail")]
        public string? Email { get; set; }
     
        [Display(Name = "Podaj nr tel. użytkownika")]        
        public string? WorkPhoneNumber { get; set; }

        [Display(Name = "Stanowisko")]
        public string? Stanowisko { get; set; }
    }

  
}
