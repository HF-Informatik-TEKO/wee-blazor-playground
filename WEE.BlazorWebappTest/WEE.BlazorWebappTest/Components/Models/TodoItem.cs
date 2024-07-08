namespace WEE.BlazorWebappTest.Components.Models;

public record TodoItem
{
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
}
