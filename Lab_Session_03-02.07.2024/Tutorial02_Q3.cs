using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02_Q3
{
    public class TemperatureTracker
    {
        private double[] dailyTemperatures;

        // Constructor
        public TemperatureTracker(int numberOfDays)
        {
            dailyTemperatures = new double[numberOfDays];
        }

        // Method to input temperatures for each day
        public void InputTemperatures()
        {
            for (int i = 0; i < dailyTemperatures.Length; i++)
            {
                Console.Write($"Enter temperature for Day {i + 1}: ");
                if (double.TryParse(Console.ReadLine(), out double temperature))
                {
                    dailyTemperatures[i] = temperature;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid temperature.");
                    i--; // Re-prompt for the same day
                }
            }
        }

        // Method to display the weekly temperature report
        public void DisplayTemperatureReport()
        {
            Console.WriteLine("\nWeekly Temperature Report:");
            for (int i = 0; i < dailyTemperatures.Length; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyTemperatures[i]}°C");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days in the week: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfDays) && numberOfDays > 0)
            {
                TemperatureTracker tracker = new TemperatureTracker(numberOfDays);
                tracker.InputTemperatures();
                tracker.DisplayTemperatureReport();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of days.");
            }
        }
    }
}
