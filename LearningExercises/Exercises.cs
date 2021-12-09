using System;
using System.Collections.Generic;
using System.Text;

namespace LearningExercises
{
    public partial class Program
    {
        private static void RunExerciseOne()
        {
            var firstName = "Gabriel";
            var lastName = "Molander";

            Console.WriteLine( "Hello {0} {1}! I’m glad to inform you that" +
                " you are the test subject of my very first assignment!", 
                firstName, lastName);
        }

        private static void RunExerciseTwo()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var yesterday = today.AddDays(-1);

            Console.WriteLine("Todays date is {0}.", today.ToShortDateString());
            Console.WriteLine("Tomorrows date is {0}.", tomorrow.ToShortDateString());
            Console.WriteLine("Yesterdays date was {0}.", yesterday.ToShortDateString());
        }

        private static void RunExerciseThree()
        {
            Console.Write("Enter your first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Your full name is {0} {1}", firstName, lastName);
        }

        private static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG";

            str = str
            .Replace("quick", "brown")
            .Insert(str.IndexOf("DOG"), "lazy ")
            .ToLower()
            .Substring(1)
            .Insert(0, str[0].ToString());

            Console.WriteLine(str);
        }

        private static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";

            str = str
            .Insert(str.Length - 1, ",6,7,8,9,10")
            .Substring(str.IndexOf("["))
            .Replace("2,3,", "");

            Console.WriteLine(str);
        }
    }
}
