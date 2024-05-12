using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de estreno")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Genero")]
        public string? Genre { get; set; }

        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "El campo Precio debe ser un número válido.")]
        [Display(Name = "Precio")]
        public decimal? Price { get; set; }
    }
}
