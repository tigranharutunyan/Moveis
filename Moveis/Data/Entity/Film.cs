using System.ComponentModel.DataAnnotations.Schema;
using Moveis.Enum;
namespace Moveis.Data.Entity;

public class Film
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public string Description { get; set; } 
    public string? AllowAge { get;set; }
    [ForeignKey("Director")]
    public int DirectorId { get; set; } 
    public Director Director { get; set; }
    [ForeignKey("Country")]
    public  int CountryId { get; set; } 
    public Country Country { get; set; }
    public LenguageEnum Lenguage { get; set; }
    public QualityEnum Quality { get; set; }    
    public GenreEnum Genre { get; set; }   
    public DateTime? DOC { get; set; }
    public string? Duration { get; set; }    
    public string ImageUrl { get; set; }

 }
