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
            string nameOfProject = Console.ReadLine();
            Project project = new Project(nameOfProject);
        }
    }
}
