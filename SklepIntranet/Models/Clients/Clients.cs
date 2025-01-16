using System.ComponentModel.DataAnnotations;

namespace SklepIntranet.Models.Clients
{
    public class Clients
    {

        [Key]

        public int IdClient { get; set; }

        [Display(Name = "nr klienta.")]
        [Required(ErrorMessage = "Podaj nr klienta.")]
        public int ClientIdNumber { get; set; }

        [Display(Name = "Imię")]
        [Required(ErrorMessage = "Podaj imię klienta.")]
        public string? ClientName { get; set; }

        [Display(Name = "Nazwisko")]
        
        public string? ClientSurname { get; set; }

        [Display(Name = "email")]
        
        public string? ClientEmail { get; set; }

        [Display(Name = "Telefon")]
        
        public string? ClientPhoneNumber { get; set; }

        [Display(Name = "Status klienta")]        
        public string? ClientStatus { get; set; }






    }
}
