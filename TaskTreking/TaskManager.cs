using System;
using System.Collections.Generic;

namespace TaskTreking
{
    public class TaskManager
    {
        Random random = new Random();

        private List<ITask> GenerateAllTasks(){
            int count = random.Next(5, 30);
            ITask task;
            List<ITask> tasks = new List<ITask>();
 
            for (int i = 0; i < count; i++)
            {
                task = GetTypeOfTask();
                task.Number = i;
                task.Description = "- " + 1;
                task.status = Status.Planned;
                task.Complexity = (random.Next(0, 50) / 10);
                task.Priority = (random.Next(0, 50) / 10);
                tasks.Add(task);
            }

            return tasks;
        }

        private ITask GetTypeOfTask(){
            ITask task;
            int typeOfTask = random.Next(0, 100);
            if(typeOfTask < 33){
                task = new Feture();
            }
            else if(typeOfTask > 33 && typeOfTask < 66){
                task = new Bug();
            }
            else{
                task = new TechnicalDebt();
            }

            return task;
        }
    }
}
