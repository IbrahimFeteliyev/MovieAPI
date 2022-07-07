using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieManager _movieManager;

        public MovieController(IMovieManager movieManager)
        {
            _movieManager = movieManager;
        }

        [HttpGet("getall")]
        public IActionResult GetAllMovie()
        {
            var movies = _movieManager.GetAllMovies();

            if (movies.Count == 0)
                return Ok(new { status = 200, message = "Couldn't find any movie" });

            return Ok(new { status = 200, message = movies });
        }


        [HttpGet("movielist")]
        public IActionResult MovieList()
        {
            Console.WriteLine("Coming from server");
            var movieList = _movieManager.GetAllMovieList();

            return Ok(new { status = 200, message = movieList });
        }


        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {

            var movie = _movieManager.GetMovieById(id);

            return Ok(new { status = 200, message = movie });
        }


        [HttpPost("add")]
        public IActionResult AddMovie(AddMovieDTO movie)
        {
            try
            {
                _movieManager.AddMovie(movie);
            }
            catch (Exception e)
            {
                return Ok(new { status = 400, message = e });
            }
            return Ok(new { status = 200, message = "Movie added." });
        }






    }
}
