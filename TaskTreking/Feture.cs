using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    class Feture : ITask
    {
        public int Number { get; set; }
        public string Description { get; set; }
        public int Complexity { get; set; }
        public int Priority { get; set; }
        public int Duration { get; set; }
        public Status status { get; set; }
        public ITask RefTask { get; set; }

    public int GetDuration()
        {
            return Complexity * Priority;
        }
    }
}
