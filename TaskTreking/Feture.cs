using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    class Feture : ITask
    {
        private int number;
        public int Number { get; set; }
        
        public string Description { get; set; }

        public int Priority { get; set; }

        public int Duration { get; set; }
        public int Complexity { get; set; }

        public Status Status;

        public int GetDuration()
        {
            return Complexity * Priority;
        }

        public void SetStatus(Status status)
        {
            Status = status;
        }
    }
}
