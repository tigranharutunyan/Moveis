using Moveis.Enum;
namespace Moveis.ViewModel.Film
{
    public class FilmAddEdit
    {
        public int Id { get;set; }  
        public string Name { get; set; }    
        public string Description { get; set; }
        public string AllowAge { get; set; }        
        public LenguageEnum Lenguage { get;set; }   
        public GenreEnum Genre { get;set; } 
        public QualityEnum Quality { get; set; }
        public int DirectorsId { get; set; }
        public  int CountryId { get; set; }
        public DateTime? DOC { get; set; }
        public string Duration { get; set; }

    }
}
