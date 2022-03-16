using CM.Domain;

namespace CM.Service.Interface
{
    public interface IMovieService
    {
        void Add(Movie movie);
        IEnumerable<Movie> GetAll();
        Movie Get(Guid id);
        void Update(Guid id, Movie movie);
        void Delete(Guid id);
    }
}
