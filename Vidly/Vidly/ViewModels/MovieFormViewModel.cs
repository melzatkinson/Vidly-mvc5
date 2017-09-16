using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
  public class MovieFormViewModel
  {
    public int? Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Display( Name = "Genre" )]
    [Required]
    public byte? GenreId { get; set; }

    [Display( Name = "Release Date" )]
    [Required]
    [Column( TypeName = "Date" )]
    public DateTime? ReleaseDate { get; set; }

    [Display( Name = "Number in Stock" )]
    [Range( 1, 20 )]
    [Required]
    public byte? NumberInStock { get; set; }

    public IEnumerable<Genre> Genre { get; set; }

    //-------------------------------------------------------------------------

    public string Title
    {
      get
      {
        return Id == 0 ? "New Movie" : "Edit Movie";
      }
    }

    //-------------------------------------------------------------------------

    public MovieFormViewModel()
    {
      Id = 0;
    }

    //-------------------------------------------------------------------------

    public MovieFormViewModel( Movie movie )
    {
      Id = movie.Id;
      Name = movie.Name;
      GenreId = movie.GenreId;
      ReleaseDate = movie.ReleaseDate;
      NumberInStock = movie.NumberInStock;
    }

    //-------------------------------------------------------------------------
  }
}