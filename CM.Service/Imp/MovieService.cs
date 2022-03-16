using CM.Data.Interfaces;
using CM.Domain;
using CM.Service.Interface;

namespace CM.Service.Imp
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _repository;

        public MovieService(IMovieRepository repository)
        {
            _repository = repository;
        }

        public void Add(Movie movie)
        {
            if(movie != null)
            {
                _repository.Add(movie);
            }
            else
            {
                Console.WriteLine("Campo requerido");
            }
            
        }

        public void Delete(Guid id)
        {
            _repository.Delete(id);
        }

        public Movie Get(Guid id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(Guid id, Movie movie)
        {
            _repository.Update(id, movie);
        }
    }
}
