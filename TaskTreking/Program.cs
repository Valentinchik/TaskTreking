﻿using System;
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
            WorkProcess();
            Console.ReadLine();

        }

        static void Continue()
        {
            Console.WriteLine();
            Console.Write("To continue press Enter");
            Console.ReadLine();
            Console.Clear();
        }

        static void WorkProcess()
        {
            Console.Write("Enter name project: ");
            string nameOfProject = Console.ReadLine();
            Project project = new Project(nameOfProject);
            TaskManager tManager = new TaskManager();
            project.AllTasksInStart = tManager.GenerateAllTasks();

            Process process = new Process(project, 3, 7);

            InfoProject.WriteInfoProject(project, 0);
            Continue();

            process.IterationGeneration();

            BugGenerating bugGenerating = new BugGenerating(project);

            while (project.AllTasksInStart.Count != 0 || project.ToDoTasks.Count != 0 || project.InProgress.Count != 0)
            {
                process.StartDay();

                if (project.Done.Count != 0)
                {
                    bugGenerating.GeneratBug();
                }

                Continue();
            }

            Console.WriteLine("End project!");
            Console.ReadLine();
        }
    }
}
