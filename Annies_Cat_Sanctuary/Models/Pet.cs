using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Annies_Cat_Sanctuary.Models;

public class Pet
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateOnly BirthDate { get; set; }

    public string? HealthStatus { get; set; }

    public string? Breed { get; set; }

    public int Age { get; set; }

    [Required]
    [RegularExpression("Male|Female", ErrorMessage = "Sex must be 'Male' or 'Female'.")]
    public string Sex { get; set; }

    public bool Vaccinated { get; set; }

    public bool TemperamentWCats { get; set; }

    public bool TemperamentWDogs { get; set; }

    public bool TemperamentWChildren { get; set; }

    public string? Description { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

}