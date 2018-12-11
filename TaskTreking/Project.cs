using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    class Project
    {
        public string Name { get; set; }
        public List<ITask> AllTasksInStart = new List<ITask>();
        public List<ITask> ToDoTasks = new List<ITask>();
        public List<ITask> InProgress = new List<ITask>();
        public List<ITask> Done = new List<ITask>();

        public int Bugs;
        public int DayIteration = 0;

        public Project(string name){
            Name = name;
        }
    }
}
