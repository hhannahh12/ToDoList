using System;

public class ToDoListItem
{
    public Guid itemId { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool Completed { get; set; }

    public ToDoListItem()
    {
        itemId = Guid.NewGuid();
    }
}