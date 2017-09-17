using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
  public class MovieDto
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public GenreDto Genre { get; set; }

    public byte GenreId { get; set; }

    [Column( TypeName = "Date" )]
    public DateTime ReleaseDate { get; set; }

    [Column( TypeName = "Date" )]
    public DateTime DateAdded { get; set; }

    [Range( 1, 20 )]
    public byte NumberInStock { get; set; }
  }
}