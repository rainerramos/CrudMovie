using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CM.Domain
{
    [Table("Movie")]
    public class Movie
    {
        public Movie()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        [Required]
        public string Title { get; set; }     

        [Required(ErrorMessage ="ReleaseDate é obrigatório")]
        public DateTime ReleaseDate { get; set; }        
        public string Sinopse { get; set; }        
        public string Cast { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }
    }
}
