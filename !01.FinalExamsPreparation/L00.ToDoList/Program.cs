using System;
using System.Collections.Generic;
using System.Linq;

namespace L00.ToDoList
{
    public class Tasks
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        public Tasks(string name)
        {
            Name = name;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{Name}{(IsCompleted ? " [Done]" : "")}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tasks> taskList = new List<Tasks>();
            string input;

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] commandParts = input.Split(new[] { ' ' }, 2);
                string command = commandParts[0];
                string taskName = commandParts.Length > 1 ? commandParts[1].Trim('"') : string.Empty;

                switch (command)
                {
                    case "AddTask":
                        if (!taskList.Any(t => t.Name == taskName))
                        {
                            taskList.Add(new Tasks(taskName));
                        }
                        break;

                    case "RemoveTask":
                        var taskToRemove = taskList.FirstOrDefault(t => t.Name == taskName);
                        if (taskToRemove != null)
                        {
                            taskList.Remove(taskToRemove);
                        }
                        break;

                    case "CompleteTask":
                        var taskToComplete = taskList.FirstOrDefault(t => t.Name == taskName);
                        if (taskToComplete != null)
                        {
                            taskToComplete.IsCompleted = true;
                        }
                        break;

                    case "ListTasks":
                        foreach (var task in taskList)
                        {
                            Console.WriteLine(task);
                        }
                        break;
                }
            }
        }
    }
}