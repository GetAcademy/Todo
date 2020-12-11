using System;
using System.Collections.Generic;
using System.Text;

namespace Todo
{
    class TodoList
    {
        private DateTime _date;
        private List<Task> _tasks;
        private int _selectedIndex;

        public TodoList()
        {
            _date = DateTime.Now;
            _tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            _tasks.Add(task);
        }

        public void Show()
        {
            Console.WriteLine(_date.ToString("D"));
            for (var index = 0; index < _tasks.Count; index++)
            {
                var task = _tasks[index];
                if (index == _selectedIndex)
                {
                    Console.Write(" * ");
                }
                if (task.IsMatchDate(_date)) task.Show();
            }

            if (_selectedIndex == _tasks.Count)
            {
                Console.WriteLine(" * ");
            }
        }

        public void MoveDays(int deltaDays)
        {
            _date = _date.AddDays(deltaDays);
        }

        public void MoveSelection(int deltaIndex)
        {
            _selectedIndex += deltaIndex;
        }
    }
}
