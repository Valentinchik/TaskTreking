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
        public string Description { get; set; }
        
        public int Coplexity { get; set; }
    }
}
