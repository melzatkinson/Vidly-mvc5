using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
    //-------------------------------------------------------------------------

    List<Movie> _movies = new List<Movie>
    {
      new Movie() {Name = "Shrek", Id = 0},
      new Movie() {Name = "Wall-e", Id = 1}
    };

    //-------------------------------------------------------------------------

    public ActionResult Index()
    {
      var viewModel = new MovieViewModel
      {
        Movies = _movies
      };

      return View( viewModel );
    }

    //-------------------------------------------------------------------------

    public ActionResult Details( int id )
    {
      return View( _movies[ id ] );
    }

    //-------------------------------------------------------------------------
  }
}