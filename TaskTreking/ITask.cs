using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    interface ITask
    {
        int Number { get; set; }
        string Description { get; set; }
        Status status { get; set; }
        int Complexity { get; set; }
        int Priority { get; set; }
        int GetDuration();
        int Duration { get; set; }
    }
}