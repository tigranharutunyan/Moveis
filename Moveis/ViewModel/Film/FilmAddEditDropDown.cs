using Moveis.Enum;

namespace Moveis.ViewModel.Film
{
    public class FilmAddEditDropDown
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenreEnum Genre { get; set; }
        public LenguageEnum Lenguage { get; set; }
        public QualityEnum Quality { get; set; }
        public DateTime DOC { get; set; }
        public int CountryId { get; set; }
        public int DirectorId { get; set; }
        public string AllowAge { get; set; }
    }
}
