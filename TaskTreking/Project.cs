using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    class Project
    {
        public List<ITask> AllTasksInStart;
        public List<ITask> ToDoTasks;
        public List<ITask> InProgress;
        public List<ITask> Done;
    }
}
