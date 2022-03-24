using CM.Data.Interfaces;
using CM.Domain;
using Microsoft.EntityFrameworkCore;

namespace CM.Data.Imp
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MainContext _db;

        public MovieRepository(MainContext db)
        {
            _db = db;
        }

        public void Add(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        }

        public void Delete(Guid id)
        {
            Movie movie = GetById(id);

            if (movie != null)
            {
                _db.Movies.Remove(movie);
                _db.SaveChanges();
            }
        }

        public Movie GetById(Guid id)
        {
           return _db.Movies.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _db.Movies;
        } 

        public void Update(Guid id, Movie movieDTO)
        {
            Movie movie = GetById(id);
            
            if (movie != null)
            {
                movieDTO.SetId(movie.Id);
                _db.Movies.Update(movie);
                _db.SaveChanges();
            }
        }

    }
}
