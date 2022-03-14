using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieLab.Models;
using System.ComponentModel.DataAnnotations;

namespace MovieLab.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}