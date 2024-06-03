namespace WEE.BlazorWebappTest.Components.Models;

public record MyPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMale { get; set; }
}
