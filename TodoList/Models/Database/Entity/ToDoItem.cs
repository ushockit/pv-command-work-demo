using System;
namespace TodoList.Models.Database.Entity
{
    public enum TodoPriority
    {
        Low,
        Normal,
        Hight
    }
    public class ToDoItem : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TodoPriority Priority { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool Completed { get; set; }
    }
}
