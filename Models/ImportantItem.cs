namespace TodoListApp.Models;

public class ImportantItem:TodoItem
{
    public string? Priority { get; private set; }
    public void PriorityLevel(int value){
        switch(value){
            case 0:
                Priority ="Not Important";
                break;
            case 1:
                Priority ="Important";
                break;
            case 2:
                Priority ="very Important";
                break;
            default:
                Priority ="has not assigned";
                break;
        }
    }
    public ImportantItem(int value)
    {
        PriorityLevel(value);
    }
    public override string ToString()
    {
        return base.ToString()+Priority;
    }
}