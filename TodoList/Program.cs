using System;

namespace TodoList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int action;

            while(true)
            {
                Console.Clear();

                Console.WriteLine("[1] Create new task");
                Console.WriteLine("[2] Show all tasks");
                Console.WriteLine("[3] Edit task");
                Console.WriteLine("[4] Remove task");
                Console.WriteLine("[5] Exit");

                int.TryParse(Console.ReadLine(), out action);

                switch(action)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:


                        break;
                    case 4:

                        break;

                    case 5:
                        break;
                }
            }
        }
    }
}