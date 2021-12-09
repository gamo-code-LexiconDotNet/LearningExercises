using System;
using System.Globalization;
using System.Text;

namespace LearningExercises
{
    public partial class Program
    {
        private static void RunExerciseOne()
        {
            var firstName = "Gabriel";
            var lastName = "Molander";

            Console.WriteLine("Hello {0} {1}! I’m glad to inform you that" +
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

        private static void RunExerciseSix()
        {
            int a, b;

            Console.Write("Input an integer: ");
            if (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("You must input a number.");
                return;
            }

            Console.Write("Input another integer: ");
            if (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("You must input a number.");
                return;
            }

            Console.WriteLine("Max: {0}", Math.Max(a, b));
            Console.WriteLine("Min: {0}", Math.Min(a, b));
            Console.WriteLine("Difference: {0}", Math.Abs(a - b));
            Console.WriteLine("Sum: {0}", a + b);
            if (b != 0)
                Console.WriteLine("Ratio: {0:0.00}", a / (double)b);
            else
                Console.WriteLine("Ratio: Cannot divide by zero.");
        }

        private static void RunExerciseSeven()
        {
            double r;

            Console.Write("Input a circle radius: ");
            if (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("You must input a number.");
                return;
            }

            Console.WriteLine("Area: {0:0.00}",
                Math.PI * Math.Pow(r, 2));
            Console.WriteLine("Volume: {0:0.00}",
                (4 * Math.PI * Math.Pow(r, 3) / 3));
        }

        private static void RunExerciseEight()
        {
            double a;

            Console.Write("Input a decimal number: ");
            if (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("You must input a decimal number.");
                return;
            }

            Console.WriteLine("Square root: {0:0.00}", Math.Sqrt(a));
            Console.WriteLine("Cube: {0:0.00}", Math.Pow(a, 2));
            Console.WriteLine("Power 10: {0:0.00}", Math.Pow(a, 10));
        }

        private static void RunExerciseNine()
        {
            string name;
            DateTime birthdate;
            string dateFormat = "yy-MM-dd";

            Console.Write("Hello, what is your name?: ");
            name = Console.ReadLine();

            Console.Write("Hello {0}, what is your birth date ({1})?: ", name, dateFormat);
            if (!DateTime.TryParseExact(
                Console.ReadLine(),
                dateFormat,
                new CultureInfo("sv-SE"),
                DateTimeStyles.None,
                out birthdate))
            {
                Console.WriteLine("You must input a date in the right format.");
                return;
            }

            string answer;
            bool hadBeer = false;
            bool isOfAge = birthdate.AddYears(18) < DateTime.Now;
            if (isOfAge)
            {
                Console.Write("Do you want a beer? y/n: ");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                {
                    Console.WriteLine("Thankyou for your order.");
                    hadBeer = true;
                }
            }
            if (!hadBeer)
            {
                Console.Write("Do you want a coke? y/n: ");
                answer = Console.ReadLine();
                if (answer.ToLower() == "y")
                    Console.WriteLine("Here is your coke.");
                else
                    Console.WriteLine("No ther options are available.");
            }
        }
        private static void RunExerciseTen()
        {
            Console.ResetColor();
            while (true)
            {
                Console.Clear();
                Console.Write(
                    "Choose what to do:\n" +
                    "1) Divide two numbers.\n" +
                    "2) Run exercise 4\n" +
                    "3) Switch console text color\n" +
                    "0) Exit\n" +
                    "> ");

                string menuChoice = Console.ReadLine();

                Console.Clear();
                switch (menuChoice)
                {
                    case "0":
                        Console.ResetColor();
                        return;
                    case "1":
                        DivideNumbers();
                        break;
                    case "2":
                        RunExerciseFour();
                        break;
                    case "3":
                        if (Console.ForegroundColor != ConsoleColor.Red)
                            Console.ForegroundColor = ConsoleColor.Red;
                        else
                            Console.ForegroundColor = ConsoleColor.Green;
                        continue;
                    default:
                        break;
                }

                Console.Write("\nPress any key to coninue...");
                Console.ReadKey();
            }

            void DivideNumbers()
            {
                double a, b;

                if (!TryReadNumber(out a))
                    return;

                if (!TryReadNumber(out b))
                    return;

                if (b != 0)
                    Console.WriteLine("{0:0.###}", a / b);
                else
                    Console.WriteLine("Cannot divide by zero.");
            }

            bool TryReadNumber(out double num)
            {
                Console.Write("Input a number: ");
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("You must input a number.");
                    return false;
                }
                return true;
            }
        }

        private static void RunExerciseEleven()
        {
            int num;

            Console.Write("Enter a number above zero: ");

            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("You must enter a number.");
                return;
            }

            if (num < 1)
            {
                Console.WriteLine("You must enter a number above zero.");
                return;
            }

            for (int i = 1; i < num + 1; i++)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(i);
            }

            Console.WriteLine("----------");

            for (int i = num; i > 0; i--)
            {
                if (i % 2 == 0)
                    Console.ForegroundColor = ConsoleColor.Red;
                else
                    Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(i);
            }
        }

        private static void RunExerciseTwelve()
        {
            StringBuilder buffer = new StringBuilder();

            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                    buffer.AppendFormat("{0, 4}", i * j);
                buffer.Append("\n");
            }

            Console.WriteLine(buffer.ToString());
        }
    }
}
