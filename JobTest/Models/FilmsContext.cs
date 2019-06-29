namespace JobTest.Models
{
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations;
    public class FilmsContext : DbContext
    {
        public FilmsContext()
            : base("name=LocalDbConnection")
        {
        }
        public virtual DbSet<Film> Films { get; set; }
    }

    public class Film
    { 
        [Key]
        public int FilmId { get; set; }
        [MaxLength(256)]
        public string Title { get; set; }
        [MaxLength(1000)]
        public string Description { get; set; }
        public int Year { get; set; }
        [MaxLength(256)]
        public string Producer { get; set; }
        public byte[] Poster { get; set; }
        public string User { get; set; }
    }
}