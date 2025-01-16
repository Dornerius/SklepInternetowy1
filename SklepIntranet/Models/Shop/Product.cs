using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SklepIntranet.Models.Shop
{
    public class Product
    {
        [Key]
        public int IdOfProduct { get; set; }


        [Required(ErrorMessage = "Kod towaru")]       
        [Display(Name = "Wpisz kod towaru")]
        public string? CodeOfProduct { get; set; }


        [Required(ErrorMessage = "Wpisz nazwę towaru")]
        [MaxLength(30, ErrorMessage = "Nazwa towaru powinna zawierać max 30 znaków")]
        [Display(Name = "Nazwa towaru")]
        public string? NameOfProduct { get; set; }


        [Display(Name = "Dodatkowe informacje")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string? ProductDescription { get; set; }


        [Display(Name = "Cena towaru")]
        [Required(ErrorMessage = "Podaj cenę towaru")]
        public float Price { get; set; }

    }
}