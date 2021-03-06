using CM.Domain;

namespace CM.Data.Interfaces
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        IEnumerable<Movie> GetAll();
        Movie GetById(Guid id);
        void Update(Guid id, Movie movie);
        void Delete(Guid id);

    }
}
