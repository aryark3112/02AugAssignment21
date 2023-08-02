using System;
using System.Collections.Generic;
using System.Threading;

namespace _02AugAssignment21
{
    class Program
    {
        private static List<string> daysOfWeek = new List<string>
        {
            "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
        };

        private static List<string> monthsOfYear = new List<string>
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
        };

        private static List<string> fruits = new List<string>
        {
            "Apple", "Banana", "Orange", "Grapes", "Watermelon", "Mango", "Strawberry"
        };

        private static Dictionary<string, string> wordsAndMeanings = new Dictionary<string, string>
        {
            { "apple", "A round fruit with red, green, or yellow skin and firm white flesh." },
            { "bicycle", "A vehicle with two wheels, powered by pedals, and often used for transportation." },
            { "book", "A written or printed work consisting of pages glued or sewn together along one side." },
            { "tree", "A large plant with a trunk and branches made of wood that grows in nature." }
        };

        static void Main(string[] args)
        {
            Console.WriteLine("-------------------Welcome to Learning----------------------------");

            Thread daysThread = new Thread(DisplayDays);
            Thread monthsThread = new Thread(DisplayMonths);
            Thread fruitsThread = new Thread(DisplayFruits);
            Thread wordsThread = new Thread(DisplayWordsAndMeanings);

            daysThread.Start();
            Thread.Sleep(2000); // Wait for 2 seconds before starting the next thread

            monthsThread.Start();
            Thread.Sleep(5000); // Wait for 5 seconds before starting the next thread

            fruitsThread.Start();
            wordsThread.Start();

            // Wait for all threads to finish before exiting the program
            daysThread.Join();
            monthsThread.Join();
            fruitsThread.Join();
            wordsThread.Join();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void DisplayDays()
        {
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
                Thread.Sleep(14000); // Wait for 14 seconds before displaying the next day
            }
        }

        private static void DisplayMonths()
        {
            foreach (string month in monthsOfYear)
            {
                Console.WriteLine(month);
                Thread.Sleep(24000); // Wait for 24 seconds before displaying the next month
            }
        }

        private static void DisplayFruits()
        {
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
                Thread.Sleep(1000); // Wait for 1 second before displaying the next fruit
            }
        }

        private static void DisplayWordsAndMeanings()
        {
            foreach (var word in wordsAndMeanings)
            {
                Console.WriteLine("Word: " + word.Key);
                Console.WriteLine("Meaning: " + word.Value);
                Thread.Sleep(1000); // Wait for 1 second before displaying the next word and meaning
            }
        }
    }
}

