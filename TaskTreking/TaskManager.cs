using System;
using System.Collections.Generic;

namespace TaskTreking
{
    class TaskManager
    {
        Random random = new Random();

        public List<ITask> GenerateAllTasks(){
            int count = random.Next(5, 30);
            ITask task;
            List<ITask> tasks = new List<ITask>();
 
            for (int i = 0; i < count; i++)
            {
                task = GetTypeOfTask();
                task.Number = i;
                task.Description = "Task - " + i;
                task.status = Status.Planned;
                task.Complexity = (random.Next(10, 50) / 10);
                task.Priority = GetPriority(task);
                task.Duration = task.GetDuration();
                tasks.Add(task);
            }

            return tasks;
        }

        private ITask GetTypeOfTask(){
            ITask task;
            int typeOfTask = random.Next(0, 100);
            if(typeOfTask <= 85){
                task = new Feture();
            }
            else{
                task = new TechnicalDebt();
            }

            return task;
        }

        private int GetPriority(ITask task)
        {
            int priority = 0;

            if(task.GetType() == typeof(Bug))
            {
                priority = 3;
            }
            else if(task.GetType() == typeof(Feture))
            {
                priority = 2;
            }
            else
            {
                priority = 1;
            }

            return priority;
        }
    }
}
