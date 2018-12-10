using System;
namespace TaskTreking
{
    public class TechnicalDebt : ITask
    {
        public int Number { get; set; }
        public string Description { get; set; }
        public int Complexity { get; set; }
        public int Priority { get; set; }
        public int Duration { get; set; }
        public Status status { get; set; }

        public int GetDuration()
        {
            return Complexity * Priority;
        }
    }
}
