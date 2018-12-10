using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    static class InfoProject
    {
        public static void WriteInfoProject (Project project, int day)
        {
            Console.WriteLine("Out progress tasks: " + project.AllTasksInStart.Count);
            Console.WriteLine("To Do tasks: " + project.ToDoTasks.Count);
            Console.WriteLine("In progress tasks: " + project.InProgress.Count);
            Console.WriteLine();
            Console.WriteLine("Tasks Status");
            for (int i = 0; i < project.ToDoTasks.Count; i++)
            {
                Console.WriteLine(project.ToDoTasks[i].Description + "deys left: " + project.ToDoTasks[i].Duration);
            }
            Console.WriteLine();
            Console.WriteLine("Done tasks: " + project.Done.Count);

            Console.WriteLine("Fulfillment day: " + day);
        }


    }
}
