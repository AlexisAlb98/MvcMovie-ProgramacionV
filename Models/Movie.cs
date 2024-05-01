using System;
<<<<<<< HEAD
using System.Collections.Generic;

namespace MvcMovie.Models;

public partial class Movie
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? Genre { get; set; }

    public decimal? Price { get; set; }
}
=======
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
>>>>>>> 395e8c2027df72720a68a9ad24c6c61e8f92a77b
