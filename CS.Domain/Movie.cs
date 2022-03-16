namespace CM.Domain
{
    public class Movie
    {
        public Movie()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Sinopse { get; set; }
        public string Cast { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}
