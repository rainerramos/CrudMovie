using CM.Domain;

namespace CM.Service.Interface
{
    public interface IMovieService
    {
        void Add(Movie movie);
        IEnumerable<Movie> GetAll();
        Movie GetById(Guid id);
        void Update(Guid id, Movie movie);
        void Delete(Guid id);
    }
}
