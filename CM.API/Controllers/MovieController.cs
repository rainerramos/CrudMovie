using CM.Domain;
using CM.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           IEnumerable<Movie> movies = _movieService.GetAll();
            return Ok(movies);
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            _movieService.Add(movie);
            return StatusCode(201);
        }
    }
}
