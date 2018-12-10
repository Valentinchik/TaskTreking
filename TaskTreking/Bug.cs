using System;
namespace TaskTreking
{
    public class Bug : ITask
    {
        public int Complexity { get; set; }
        public int Priority { get; set; }
        public int Duration { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }

        public Bug()
        {
        }

        public void SetStatus(Status status)
        {
            
        }

        public int GetDuration()
        {
            return Complexity * Priority;
        }
    }
}
