using System;
using System.Collections.Generic;

namespace LAB5_2Enum
{
    class Program
    {

        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //List of task
            List<string> taskList = new List<string>();

            // Values with task
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine("Enter a new task for" + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);
            }
            foreach(string task in taskList)
            {
                Console.WriteLine(task);
            }
        }
    }
}
