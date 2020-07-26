using System;

namespace Lab4_6ArrayToDoListWithTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab4_6ArrayToDoListWithTasks!");

            // In this lab, you’ll be working with arrays and for loops 
            // to get practice on working with collections.

            // Scenario:You work for a company that runs a To-Do list web app. The website 
            // allows users to type in tasks for each day of the week so that they 
            // remember to do them.  You’ve been asked to use C# to create a small to-do 
            // list planner.  As usual, someone else will handle how the code will work on
            // the web, you’ve been asked to write the initial test version of the logic.

            // Requirements:The do-to list planner with cycle through each day of the 
            // week, pausing to let the user type in a task. The planner will save 
            // each task the user types in, and then display all of the days and tasks 
            // together. See the screenshot below for an example of the screen output.

            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] tasks = new string[days.Length];

            // for each value in string array days...let the user create a task.
            for (int i = 0; i < days.Length; i++) 
            {
                
                Console.WriteLine("Enter a new task for " + days[i]);
                string task = days[i] + " : " + Console.ReadLine();
                tasks[i] = task;

            }

            // print all the tasks.
            foreach (string task in tasks) 
            {
                Console.WriteLine(task);
            }

        }
    }
}
