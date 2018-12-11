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
            int taskIndex = random.Next(0, currentProject.Done.Count - 1);
            int iteration = random.Next(0, 1000);
            Bug bug = new Bug();
            ITask task;

            if(iteration < 500)
            {
                if (currentProject.Done[taskIndex].GetType() == typeof(Bug))
                {
                    GeneratBug();
                }
                else
                {
                    task = currentProject.Done[taskIndex];
                    bug.Number = currentProject.AllTasksInStart.Count;
                    bug.Description = "Bug for " + task.Description;
                    bug.status = Status.ToDo;
                    bug.Complexity = random.Next(10, 50) / 10;
                    bug.Priority = 3;
                    bug.RefTask = task;
                    task.RefTask = bug;
                    currentProject.ToDoTasks.Add(bug);
                    currentProject.Bugs++;
                }
            }
        }

        private List<Feture> GetListOfFeature()
        {
            List<Feture> fetures = new List<Feture>();
            for (int i = 0; i < currentProject.Done.Count - 1; i++)
            {
                if (currentProject.Done[i].GetType() == typeof(Feture))
                    fetures.Add((Feture)currentProject.Done[i]);
            }

            return fetures;
        }
    }
}
