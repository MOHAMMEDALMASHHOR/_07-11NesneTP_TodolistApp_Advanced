namespace TodoListApp.Models;
public class GroceriesItem:TodoItem
{
    public int Quantity { get; set; }
    public override string ToString()
    {
        return base.ToString()+$"Quantity:{Quantity}";
    }
    public GroceriesItem(int value)
    {
        Quantity = value;
    }
}