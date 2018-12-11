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
            Console.WriteLine("Name project: " + project.Name);
            Console.WriteLine();
            Console.WriteLine("Out progress tasks: " + project.AllTasksInStart.Count);
            Console.WriteLine("To Do tasks: " + project.ToDoTasks.Count);
            Console.WriteLine("In progress tasks: " + project.InProgress.Count);
            Console.WriteLine();
            Console.WriteLine("Day iteration: " + project.DayIteration);
            Console.WriteLine();
            Console.WriteLine("Tasks Status");
            for (int i = 0; i < project.InProgress.Count; i++)
            {
                Console.WriteLine(project.InProgress[i].Description + " deys left: " + project.InProgress[i].Duration);
            }
            Console.WriteLine();
            Console.WriteLine("Done tasks: " + project.Done.Count);
            Console.WriteLine();
            Console.WriteLine("Count bugs: " + project.Bugs);

            Console.WriteLine("Fulfillment day: " + day);
        }


    }
}
