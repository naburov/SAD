using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР3
{
    class ComplicateTask : ITask
    {
        List<Task> tasks;


        public int Time { get => (from t in tasks select t.Time).Sum(); }

        public string Status { get; set; }

        public List<string> Employees 
        {
            get
            {
                List<string> union = new List<string>();
                foreach (Task t in tasks)
                    union.Union(t.Employees);
                return union;
            }
        }

        public void Complete()
        {
            Status = "Завершено";
        }

        public void Start()
        {
            Status = "В процессе";
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public ComplicateTask()
        {
            tasks = new List<Task>();
        }
    }
}
