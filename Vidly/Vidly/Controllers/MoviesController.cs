using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
  public class MoviesController : Controller
  {
    private ApplicationDbContext _context;

    //-------------------------------------------------------------------------

    public MoviesController()
    {
      _context = new ApplicationDbContext();
    }

    //-------------------------------------------------------------------------

    protected override void Dispose( bool dispose )
    {
      _context.Dispose();
    }

    //-------------------------------------------------------------------------

    public ActionResult Index()
    {
      var movies = _context.Movies.Include( m => m.Genre ).ToList();

      return View( movies );
    }

    //-------------------------------------------------------------------------

    public ActionResult Details( int id )
    {
      var movie = _context.Movies.Include( m => m.Genre ).SingleOrDefault( m => m.Id == id );

      if( movie == null )
        return HttpNotFound();

      return View( movie );
    }

    //-------------------------------------------------------------------------

    public ActionResult New()
    {
      var genre = _context.Genres.ToList();

      var viewModel = new MovieFormViewModel()
      {
        ActionName = "New Movie",
        Genre = genre
      };

      return View( "MovieForm", viewModel );
    }

    //-------------------------------------------------------------------------

    public ActionResult Edit( int id )
    {
      var movie = _context.Movies.SingleOrDefault( m => m.Id == id );

      if( movie == null )
        return HttpNotFound();

      var viewModel = new MovieFormViewModel()
      {
        ActionName = "Edit Movie",
        Movie = movie,
        Genre = _context.Genres.ToList()
      };


      return View( "MovieForm", viewModel );
    }

    //-------------------------------------------------------------------------

    public ActionResult Save( Movie movie )
    {
      movie.DateAdded = DateTime.Now.Date;

      _context.Movies.Add( movie );

      _context.SaveChanges();

      return RedirectToAction( "Index", "Movies" );
    }

    //-------------------------------------------------------------------------
  }
}