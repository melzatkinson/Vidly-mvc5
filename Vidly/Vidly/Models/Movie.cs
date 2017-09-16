using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Vidly.Models
{
  public class Movie
  {
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public Genre Genre { get; set; }

    [Display( Name = "Genre" )]
    public byte GenreId { get; set; }

    [Display( Name = "Release Date" )]
    [Column( TypeName = "Date" )]
    public DateTime ReleaseDate { get; set; }

    [Column( TypeName = "Date" )]
    public DateTime DateAdded { get; set; }

    [Display( Name = "Number in Stock" )]
    [Range( 1, 20 )]
    public byte NumberInStock { get; set; }
  }
}