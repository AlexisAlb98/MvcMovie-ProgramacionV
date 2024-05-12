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

        [Display(Name = "Precio")]
        public decimal? Price { get; set; }

        [Display(Name = "Cartelera")]
        public string? Image { get; set; }

    }
}
