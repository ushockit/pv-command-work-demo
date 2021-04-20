using System;
namespace TodoList.Models.Database.Entity
{
    public class ToDoItem : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool Completed { get; set; }
    }
}
