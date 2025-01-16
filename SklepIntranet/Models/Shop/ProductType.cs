using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SklepIntranet.Models.Shop
{
    public class ProductType
    {
        [Key]
        public int IdProductType { get; set; }


        [Required(ErrorMessage = "Wpisz nazwę rodzaju produktu")]
        [MaxLength(30, ErrorMessage = "Nazwa powinna zawierać max 30 znaków")]
        [Display(Name = "Rodzaj produkty")]
        public string? ProductTypeName { get; set; }


        
        [MaxLength(30, ErrorMessage = "Nazwa powinna zawierać max 30 znaków")]
        [Display(Name = "Podkategoria")]
        public string? ProductTypeSubName { get; set; }


        [Display(Name = "Opis")]
        [Column(TypeName = "nvarchar(MAX)")]
        public string? Description { get; set; }    

    }
}