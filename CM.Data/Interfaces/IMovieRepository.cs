using CM.Domain;

namespace CM.Data.Interfaces
{
    public interface IMovieRepository
    {
        void Add(Movie movie);
        IEnumerable<Movie> GetAll();
        Movie Get(Guid id);
        void Update(Guid id, Movie movie);
        void Delete(Guid id);

    }
}
