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
        void SetStatus(Status status);
        int Complexity { get; set; }
        int Priority { get; set; }
        int GetDuration();
        int Duration { get; set; }
    }
}
