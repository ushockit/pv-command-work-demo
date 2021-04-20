using System;
namespace TodoList.Models.Database.Entity
{
    public class BaseEntity<T>
        where T : struct
    {
        public T Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
