using System.ComponentModel.DataAnnotations;

namespace SklepData.Data.Finance
{
    public class Factures
    {

        [Key]

        public int IdFacture { get; set; }

        [Display(Name = "Numer faktury")]
        [Required(ErrorMessage = "Podaj nr faktury")]
        public string? NrFacture { get; set; }

        [Display(Name = "Data wystawienia")]
        [Required(ErrorMessage = "Podaj datę wystawienia faktury")]
        public DateOnly? DateFacture { get; set; }


        [Display(Name = "Data sprzedaży")]
        [Required(ErrorMessage = "Podaj datę sprzedaży faktury")]
        public DateOnly? DateSale { get; set; }


        [Display(Name = "Nawa Działu")]
        [Required(ErrorMessage = "Podaj nazwę działu który sprzedał towar")]
        public string? Department { get; set; }


        [Display(Name = "Imię kontrahenta")]
        [Required(ErrorMessage = "Podaj imę kontrahenta, który nie jest zarejestrowany w bazie ")]
        public string? ClientNdName { get; set; }

        [Display(Name = "Nazwisko kontrahenta")]
        [Required(ErrorMessage = "Podaj nazwisko kontrahenta, który nie jest zarejestrowany w bazie ")]
        public string? ClientNdSurname { get; set; }


        [Display(Name = "Województwo i Miejscowość")]
        [Required(ErrorMessage = "Podaj Województwo i Miejscowość zamieszkania kontrahenta, który nie jest zarejestrowany w bazie")]
        public string? ClientAdressCity { get; set; }

        [Display(Name = "Ulica, nr ")]
        [Required(ErrorMessage = "Podaj ulicę nr posesji i/lub mieszkania zamieszkania kontrahenta, który nie jest zarejestrowany w bazie")]
        public string? ClientAdressStreetNr { get; set; }

        [Display(Name = "dane kontaktowe ")]
        [Required(ErrorMessage = "Podaj dane kontaktowe kontrahenta, który nie jest zarejestrowany w bazie")]
        public string? ClientContact { get; set; }

        [Display(Name = "Nazwa towaru")]
        [Required(ErrorMessage = "Podaj nazwę towaru")]
        public string? ProductName { get; set; }

        [Display(Name = "Kwota netto")]
        [Required(ErrorMessage = "Podaj kwotę netto")]
        public decimal PriceNetto { get; set; } 
       
        [Display(Name = "Kwota podatku VAT")]
        [Required(ErrorMessage = "Podaj kwotę podatku VAT")]
        public decimal PriceVAT { get; set; } 
        
        [Display(Name = "Kwota bruto")]
        [Required(ErrorMessage = "Podaj kwotę brutto")]
        public decimal PriceBrutto { get; set; }

    }
}
