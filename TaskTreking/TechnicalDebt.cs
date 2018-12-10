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

        public TechnicalDebt()
        {
        }
        public int GetDuration()
        {
            return Complexity * Priority;
        }

        public void SetStatus(Status status)
        {
            
        }
    }
}
