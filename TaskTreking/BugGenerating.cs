using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    class BugGenerating
    {
        Random random = new Random();
        Project currentProject;

        public BugGenerating(Project project)
        {
            currentProject = project;
        }

        public void GeneratBug()
        {
            int iteration = random.Next(0, 1000);

            if(iteration < 300)
            {
                List<ITask> tasks = GetListOfTasks();
                int taskIndex = random.Next(0, tasks.Count - 1);
                ITask task = tasks[taskIndex];
                Bug bug = new Bug();
                bug.Number = currentProject.AllTasksInStart.Count;
                bug.Description = "Bug for " + task.Description;
                bug.status = Status.ToDo;
                bug.Complexity = random.Next(10, 50) / 10;
                bug.Priority = 3;
                bug.Duration = bug.Complexity * bug.Priority;
                bug.RefTask = task;
                task.RefTask = bug;
                task.status = Status.InProgress;
                currentProject.ToDoTasks.Add(bug);
                currentProject.Bugs++;
            }
        }

        private List<ITask> GetListOfTasks()
        {
            List<ITask> tasks = new List<ITask>();
            foreach (ITask t in currentProject.Done)
            {
                if (t.GetType() != typeof(Bug))
                    tasks.Add(t);
            }

            return tasks;
        }
    }
}
