using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    class Process
    {
        private Project CurrentProject;
        private int day = 0;
        private int CountTeam = 0;
        private int LengthIteration = 0;

        public Process(Project project, int countTeam, int lengthIteration)
        {
            CurrentProject = project;
            CountTeam = countTeam;
            LengthIteration = lengthIteration;
        }

        public void StartDay()
        {
            CurrentProject.DayIteration++;
            if (CurrentProject.DayIteration > LengthIteration && CurrentProject.AllTasksInStart.Count > 0)
            {
                CurrentProject.DayIteration = 1;
                IterationGeneration();
            }
            else if(CurrentProject.DayIteration > LengthIteration)
            {
                CurrentProject.DayIteration = 1;
            }

            while(CurrentProject.InProgress.Count < CountTeam && CurrentProject.ToDoTasks.Count > 0)
            {
                ITask tempTask = FindMaxPriority(CurrentProject.ToDoTasks);
                CurrentProject.InProgress.Add(tempTask);
                CurrentProject.ToDoTasks.Remove(tempTask);
            }

            TaskProcess();

            InfoProject.WriteInfoProject(CurrentProject, day);
        }

        ITask FindMaxPriority(List<ITask> tasks)
        {
            foreach(ITask t in tasks)
            {
                if(t.GetType() == typeof(Bug))
                {
                    return t;
                }
            }
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
            while (time < maxTime && CurrentProject.AllTasksInStart.Count > 0)
            {
                ITask tempTask = FindMaxPriority(CurrentProject.AllTasksInStart);
                time += tempTask.Duration;
                CurrentProject.ToDoTasks.Add(tempTask);
                CurrentProject.AllTasksInStart.Remove(tempTask);
            }
        }

        void TaskProcess()
        {
            day++;
            for(int i= CurrentProject.InProgress.Count - 1; i>= 0; i--)
            {
                if(CheckBugInTask(CurrentProject.InProgress[i]) || CheckBugInTechnicalDebt(CurrentProject.InProgress[i]))
                {
                    continue;
                }
                WorkingTask(CurrentProject.InProgress[i]);
            }
        }

        void WorkingTask(ITask task)
        {
            task.Duration--;
            if (task.Duration == 0)
            {
                if (task.GetType() == typeof(Bug))
                {
                    Bug temp = (Bug)task;
                    CurrentProject.Done.Add(temp.RefTask);
                    CurrentProject.InProgress.Remove(temp.RefTask);
                }
                CurrentProject.Done.Add(task);
                CurrentProject.InProgress.Remove(task);
            }
        }

        bool CheckBugInTask(ITask task)
        {
            if (task.GetType() == typeof(Feture))
            {
                Feture temp = (Feture)task;
                if (temp.RefBug != null)
                {
                    return true;
                }
            }
            return false;
        }

        bool CheckBugInTechnicalDebt(ITask task)
        {
            if (task.GetType() == typeof(TechnicalDebt))
            {
                TechnicalDebt temp = (TechnicalDebt)task;
                if (temp.RefBug != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
