using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Moveis.Enum
{
    public enum  GenreEnum
    {
        Adventure = 1,
        Comedy = 2,
        Drama = 3 ,
        Fantasy = 4,
        Action = 5,
        Documentary = 6,
        Horror = 7,
        Musical = 8,
        Mystery = 9,
        Romance = 10,
        [Display(Name = "Science Fiction")]
        Science_Fiction = 11,
        Thriller = 12,
        Western = 13,

    }
}
