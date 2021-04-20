using System;
namespace TodoList.Models.Database.Repository
{
    public interface IRepository<T>
    {
        void Create(T item);
    }
}
