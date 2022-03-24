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

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _movieService.Delete(id);
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            Movie movie = _movieService.GetById(id);
            return Ok(movie);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, Movie movie)
        {
            _movieService.Update(id, movie);
            return NoContent();
        }
    }
}
