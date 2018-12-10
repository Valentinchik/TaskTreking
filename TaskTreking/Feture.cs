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
        
        public int Coplexity { get; set; }

        public int Priority { get; set; }

        public int Duration { get; set; }
<<<<<<< HEAD

        public int Complexity { get; set; }
=======
>>>>>>> e77fd01678bcf36bd7ea712d6125ccd46d8c7a11

        public Status status { get; set; }

        public void SetStatus(string status)
        {
            Status = Status.Done;
        }
<<<<<<< HEAD
=======

        public int GetDuration()
        {
            return Coplexity * Priority;
        }
>>>>>>> e77fd01678bcf36bd7ea712d6125ccd46d8c7a11
    }
}
