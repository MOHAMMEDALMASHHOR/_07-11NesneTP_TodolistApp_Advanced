
using System.Collections;

namespace TodoListApp.Models;
public class TodoList:IEnumerable
{
    private List<TodoItem> Items { get; set; }

    public TodoList(List<TodoItem> items) : this()
    {
        foreach (var item in items)
        {
            AddItem(item);
        }
    }

    private void AddItem(TodoItem item)
    {
        Items.Add(item);
    }
    public void RemoveItem(int id)
    {
        foreach (var item in Items)
        {
            if (item.Id.Equals(id))
            {
                Items.Remove(item);
            }

        }
    }
    public void MarkComplete(int id)
    {
        foreach (var item in Items)
        {
            if (item.Id == id)
            {
                item.IsComplete = true;
            }
        }
    }
    public List<TodoItem> GetDueItems(DateTime dateTime)
    {
        return Items.Where(item => item.DueDate < dateTime).ToList();

    }
    public List<TodoItem> GetItems(){
        return Items;
    }
    public TodoItem GetOneItem(int id)
    {
        foreach (var item in Items)
        {
            if (item.Id==id)
            {
                return item;
            }
        }
        throw new Exception("404");
    }
    public void DisplayTask(){
        foreach (var item in Items)
        {
            System.Console.WriteLine(item.ToString());
        }
    }


    public TodoList()
    {
        Items = new List<TodoItem>();
    }
    public List<TodoItem> SortList(){
        foreach (var item in Items)
        {
            System.Console.WriteLine(item);
        }
        System.Console.WriteLine(new string('=',60));

        Items.Sort();
        foreach (var item in Items)
        {
            System.Console.WriteLine(item);
        }
        return Items;
        
    }

    public IEnumerator GetEnumerator()
    {
        return Items.GetEnumerator();
    }
}