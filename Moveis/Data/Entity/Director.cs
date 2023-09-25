namespace Moveis.Data.Entity
{
    public class Director
    {
        public int Id { get; set; } 
        public string Name { get; set; }   

        public ICollection<Film> DirectorFilms { get; set; } 
    }
}
