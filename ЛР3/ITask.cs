using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР3
{
    interface ITask
    {
        int Time { get; }
        string Status { get; set; }
        List<string> Employees { get; }

        void Start();
        void Complete();
    }
}
