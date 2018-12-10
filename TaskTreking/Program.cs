using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTreking
{
    public enum Status
    {
        Planned,
        ToDo,
        InProgress,
        Done
    }

    class Program
    {
        static void Main(string[] args)
        {
            string nameOfProject = Console.ReadLine();
            Project project = new Project(nameOfProject);
            TaskManager tManager = new TaskManager();
            project.AllTasksInStart = tManager.GenerateAllTasks();

            Process process = new Process(project, 3, 7);

            InfoProject.WriteInfoProject(project, 0);

            process.IterationGeneration();

            while (project.AllTasksInStart.Count == 0 && project.ToDoTasks.Count == 0 && project.InProgress.Count == 0)
            {
                process.StartIteration();
                InfoProject.WriteInfoProject(project, 0);
                Console.Write("To continue press Enter");
                Console.ReadLine();
            }

            Console.WriteLine("End project!");
            Console.ReadLine();
        }
    }
}
