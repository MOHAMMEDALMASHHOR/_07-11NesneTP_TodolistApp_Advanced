namespace TodoListApp.Models;
public class UrgentItem : ImportantItem
{
    public bool IsUrgent { get; set; } 
    public UrgentItem(int value) : base(value)
    {
    }

    public UrgentItem(bool isUrgent,int value):base(value)
    {
        IsUrgent = isUrgent;
    }
}