using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    class Process
    {
        private Project Project;
        private int day = 0;
        private int dayIteration = 0;
        private int CountTeam = 0;
        private int LengthIteration = 0;

        public Process(Project project, int countTeam, int lengthIteration)
        {
            Project = project;
            CountTeam = countTeam;
            LengthIteration = lengthIteration;
        }

        public void StartIteration()
        {
            dayIteration++;
            if (dayIteration > LengthIteration)
            {
                dayIteration = 1;
                IterationGeneration();
            }

            while(Project.InProgress.Count < CountTeam)
            {
                ITask tempTask = FindMaxPriority(Project.ToDoTasks);
                Project.InProgress.Add(tempTask);
                Project.ToDoTasks.Remove(tempTask);
            }

            TaskProcess(Project);

            InfoProject.WriteInfoProject(Project, day);
        }

        ITask FindMaxPriority(List<ITask> tasks)
        {
            ITask tempTask = tasks[0];
            for(int i=1; i< tasks.Count; i++)
            {
                if(tempTask.Priority < tasks[i].Priority)
                {
                    tempTask = tasks[i];
                    if(tempTask.Priority == 5)
                    {
                        return tempTask;
                    }
                }
            }
            return tempTask;
        }

        public void IterationGeneration()
        {
            int time = 0;
            int maxTime = CountTeam * LengthIteration;
            while (time < maxTime)
            {
                ITask tempTask = FindMaxPriority(Project.AllTasksInStart);
                time += tempTask.Duration;
                Project.ToDoTasks.Add(tempTask);
                Project.AllTasksInStart.Remove(tempTask);
            }
        }

        void TaskProcess(Project project)
        {
            day++;
            for(int i= project.InProgress.Count - 1; i>= 0; i--)
            {
                project.InProgress[i].Duration--;
                if(project.InProgress[i].Duration == 0)
                {
                    project.Done.Add(project.Done[i]);
                    project.InProgress.Remove(project.InProgress[i]);
                }
            }
        }
    }
}
