namespace WEE.BlazorWebappTest.Components.Pages.MyTodo;

public class TodoItem
{
    public bool IsDone { get; set; } = false;
    public string? Name { get; set; }
    public DateTime? DueDate { get; set; } = DateTime.Today.AddDays(1);
    public DateTime Created { get; private set; } = DateTime.Now;

    public static bool operator !=(TodoItem e1, TodoItem e2)
        => e1.Name != e2.Name 
        && e1.DueDate != e2.DueDate;

    public static bool operator ==(TodoItem e1, TodoItem e2)
        => e1.Name == e2.Name
        && e1.DueDate == e2.DueDate;
}
