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
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        private int coplexity;
        public int Complexity
        {
            get
            {
                return coplexity;
            }
            set
            {
                coplexity = value;
            }
        }

        private int priority;
        public int Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }

        private int duration;
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }

        public Status Status;

        public void SetStatus(Status status)
        {
            Status = status;
        }

        public int GetDuration()
        {
            return coplexity * priority;
        }
    }
}
