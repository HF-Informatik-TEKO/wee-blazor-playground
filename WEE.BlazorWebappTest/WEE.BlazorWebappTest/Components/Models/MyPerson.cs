using System.ComponentModel.DataAnnotations;

namespace WEE.BlazorWebappTest.Components.Models;

public record MyPerson
{
    [Required(ErrorMessage = "First name is required.")]
    [StringLength(10)]
    public required string FirstName { get; set; }
    [Required]
    public required string LastName { get; set; }
    [Required]
    [Range(0, 150)]
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMale { get; set; }
}
