using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР3
{
    class Task : ITask
    {
        int time;
        List<string> employees;

        public int Time { get => time; }
        public string Status { get; set; }
        public List<string> Employees => employees;

        public void Complete()
        {
            Status = "Завершено";
        }

        public void Start()
        {
            Status = "В процессе";
        }

        public void SelectResponsibleEmployee(string employeeName)
        {
            employees.Add(employeeName);
        }

        public Task(int time)
        {
            this.time = time;
            Status = "Работы не начаты";
            employees = new List<string>();
        }
    }
}
