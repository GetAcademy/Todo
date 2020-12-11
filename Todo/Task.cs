using System;
using System.Collections.Generic;
using System.Text;

namespace Todo
{
    class Task
    {
        private string _description;
        private DateTime _date;
        private bool _isDone;

        public Task(string description, DateTime date)
        {
            _date = date;
            _description = description;
        }

        public void Show()
        {
            var currentColor = Console.ForegroundColor;
            if(_isDone) Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(_description);
            Console.ForegroundColor = currentColor;
        }

        public void SetAsDone()
        {
            _isDone = true;
        }

        public bool IsMatchDate(DateTime otherDate)
        {
            return _date.Date == otherDate.Date;
        }
    }
}
