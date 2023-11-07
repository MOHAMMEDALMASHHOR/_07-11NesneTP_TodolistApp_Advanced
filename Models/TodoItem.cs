namespace TodoListApp.Models;
public class TodoItem:IComparable<TodoItem>
{

    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsComplete { get; set; }
    public TodoItem()
    {
        IsComplete = false;
    }
    public TodoItem(int id, string? title, string? description, DateTime dueDate)
    {
        Id = id;
        Title = title;
        Description = description;
        DueDate = dueDate;
    }
    public override string ToString()
    {
        return $"{Id} - {Title} - {Description} - {DueDate} {IsComplete}";
    }


    public int CompareTo(TodoItem? other)
    {
        var k=-1;
        return k*this.Id.CompareTo(other.Id);
    }
}
