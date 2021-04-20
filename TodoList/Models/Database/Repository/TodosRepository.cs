using System;
using TodoList.Models.Database.Entity;

namespace TodoList.Models.Database.Repository
{
    public class TodosRepository : IRepository<ToDoItem>
    {
        public void Create(ToDoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
