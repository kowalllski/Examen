using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class TaskList
    {
        private string _name;
        private List<Task> _tasks;

        public TaskList(string name, List<Task> tasks)
        {

            this._name = name;
            this._tasks = tasks;
        }

        public string GetName()
        {
            return _name;
        }

        public void AddTask(Task task)
        {
            this._tasks.Add(task);
        }

        public List<Task> GetTasks()
        {
            return _tasks;
        }
    }
}
