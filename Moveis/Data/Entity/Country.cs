namespace Moveis.Data.Entity
{
    public class Country
    {
        public int Id { get;set; }  
        public string Name { get;set; } 
        public ICollection<Film> CountryFilms { get; set;}  

    }
}
