using System;
using TodoList.Models.Database.Entity;
using TodoList.Models.Database.Repository;

namespace TodoList
{
    class MainClass
    {
        static TodosRepository todosRepository = new TodosRepository();

        public static void Main(string[] args)
        {
            int action;

            while(true)
            {
                Console.WriteLine("[1] Create new task");
                Console.WriteLine("[2] Show all tasks");
                Console.WriteLine("[3] Edit task");
                Console.WriteLine("[4] Remove task");
                Console.WriteLine("[5] Exit");

                int.TryParse(Console.ReadLine(), out action);

                switch(action)
                {
                    case 1:
                        CreateNewTask();
                        break;
                    case 2:
                        DeleteSelectedTask(0);
                        break;
                    case 3:
                        EditTask(null);
                        break;
                    case 4:

                        break;

                    case 5:
                        break;
                }
            }
        }

        static void EditTask(ToDoItem task)
        {
            task.Name = "Edited" + task.Name;
            // TODO: save to DB
        }

        static void CreateNewTask()
        {
            todosRepository.Create(new ToDoItem
            {
                Name = "Some name",
                Description = "Some description",
                Start = DateTime.Now,
                End = new DateTime(2021, 05, 01),
                Priority = Models.Database.Entity.TodoPriority.Low
            });
        }

        static void DeleteSelectedTask(int index)
        {

        }
    }
}