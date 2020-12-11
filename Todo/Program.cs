using System;

namespace Todo
{
    class Program
    {
        static void Main(string[] args)
        {
            var todoList = new TodoList();
            todoList.AddTask(new Task("Lage middag", DateTime.Now));
            todoList.AddTask(new Task("Gjøre yoga", DateTime.Now));

            do
            {
                Console.Clear();
                todoList.Show();
                var keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow) todoList.MoveDays(-1);
                else if (keyInfo.Key == ConsoleKey.RightArrow) todoList.MoveDays(1);
                else if (keyInfo.Key == ConsoleKey.UpArrow) todoList.MoveSelection(-1);
                else if (keyInfo.Key == ConsoleKey.DownArrow) todoList.MoveSelection(1);
            } while (true);

            //task.Show();
            //task.SetAsDone();
            //task.Show();
        }
    }
}
