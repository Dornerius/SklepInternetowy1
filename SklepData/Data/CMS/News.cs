using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SklepData.Data.CMS
{
    public class News
    {

        [Key]
        public int IdNews { get; set; }
        [Required(ErrorMessage = "Wpisz tytuł aktualności")]
        [MaxLength(20, ErrorMessage = "Tytuł powinien zawierać max 20 znaków")]
        [Display(Name = "Tytuł odnośnika")]
        public string? LinkTitle { get; set; }
        [Required(ErrorMessage = "Wpisz tytuł aktualności")]
        [MaxLength(30, ErrorMessage = "Tytuł aktualności powinien zawierać max 30 znaków")]
        [Display(Name = "Tytuł")]
        public string? Title { get; set; }
        [Display(Name = "Treść")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string? Content { get; set; }
        [Display(Name = "Pozycja Wyswietlania")]
        [Required(ErrorMessage = "Wpisz pozycję wyświetlania")]
        public int Position { get; set; }

    }
}