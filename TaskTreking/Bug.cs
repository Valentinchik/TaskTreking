using System;
namespace TaskTreking
{
    class Bug : ITask
    {
        public int Complexity { get; set; }
        public int Priority { get; set; }
        public int Duration { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public Status status { get; set; }
        public ITask RefTask;

        public int GetDuration()
        {
            return Complexity * Priority;
        }
    }
}
