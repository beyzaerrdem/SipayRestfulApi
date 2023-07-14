using Microsoft.AspNetCore.Mvc;
using SipayRestfulApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SipayRestfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetAllMovie()
        {
            var movies = new Movies();
            IEnumerable<Movie> m;
            m = movies.MovieList.OrderBy(x => x.Name);
            if (movies.MovieList == null)
            {
                return StatusCode(404, "Not Found");
            }
            return StatusCode(200,m);
        }


        [HttpGet("{id}")]
        public IActionResult GetByIdMovie(int id)
        {
            var movie = new Movies();
            var movieList = movie.MovieList.Where(x => x.Id == id).FirstOrDefault();
            if (movieList == null) 
            { 
                return StatusCode(404, "Not Found");
            }
            return StatusCode(200, movieList);  
        }


        // POST api/<MovieController>

        [HttpPost]
        public IActionResult AddMovie([FromBody] Movie m)
        {
            var movie = new Movies();
            movie.MovieList.Add(m);
            return StatusCode(200, movie);
        }

        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] Movie m)
        {
            var movie = new Movies();
            var movieId = movie.MovieList.Where(x=>x.Id == id).FirstOrDefault();
            movieId.Name = m.Name;
            movieId.Description = m.Description;
            movieId.Time = m.Time;
            movieId.ImdbPoint = m.ImdbPoint;
            return StatusCode(200, movie);
        }

        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movie = new Movies();
            var movieId = movie.MovieList.Where(x => x.Id == id).FirstOrDefault();
            movie.MovieList.Remove(movieId);
            if (movieId == null) return StatusCode(404, "Not Found");
            return StatusCode(200);

        }

        [HttpPatch("{id}")]
        public IActionResult UpdateMovieProperty(int id, [FromBody] Movie m)
        {
            var movie = new Movies();
            var mov = movie.MovieList.Where(x => x.Id == id).FirstOrDefault();
            mov.Name = m.Name;
            return StatusCode(200, movie);
        }

    }
}
