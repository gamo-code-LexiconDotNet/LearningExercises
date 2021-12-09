using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using static System.Console;

namespace LearningExercises
{
    public partial class Program
    {
        private static void RunExerciseOne()
        {
            var firstName = "Gabriel";
            var lastName = "Molander";

            WriteLine("Hello {0} {1}! I’m glad to inform you that" +
                " you are the test subject of my very first assignment!",
                firstName, lastName);
        }

        private static void RunExerciseTwo()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var yesterday = today.AddDays(-1);

            WriteLine("Todays date is {0}.", today.ToShortDateString());
            WriteLine("Tomorrows date is {0}.", tomorrow.ToShortDateString());
            WriteLine("Yesterdays date was {0}.", yesterday.ToShortDateString());
        }

        private static void RunExerciseThree()
        {
            Write("Enter your first name: ");
            var firstName = ReadLine();
            Write("Enter your last name: ");
            var lastName = ReadLine();

            WriteLine("Your full name is {0} {1}", firstName, lastName);
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

            WriteLine(str);
        }

        private static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";

            str = str
            .Insert(str.Length - 1, ",6,7,8,9,10")
            .Substring(str.IndexOf("["))
            .Replace("2,3,", "");

            WriteLine(str);
        }

        private static void RunExerciseSix()
        {
            int a, b;

            Write("Input an integer: ");
            if (!int.TryParse(ReadLine(), out a))
            {
                WriteLine("You must input a number.");
                return;
            }

            Write("Input another integer: ");
            if (!int.TryParse(ReadLine(), out b))
            {
                WriteLine("You must input a number.");
                return;
            }

            WriteLine("Max: {0}", Math.Max(a, b));
            WriteLine("Min: {0}", Math.Min(a, b));
            WriteLine("Difference: {0}", Math.Abs(a - b));
            WriteLine("Sum: {0}", a + b);
            if (b != 0)
                WriteLine("Ratio: {0:0.00}", a / (double)b);
            else
                WriteLine("Ratio: Cannot divide by zero.");
        }

        private static void RunExerciseSeven()
        {
            double r;

            Write("Input a circle radius: ");
            if (!double.TryParse(ReadLine(), out r))
            {
                WriteLine("You must input a number.");
                return;
            }

            WriteLine("Area: {0:0.00}",
                Math.PI * Math.Pow(r, 2));
            WriteLine("Volume: {0:0.00}",
                (4 * Math.PI * Math.Pow(r, 3) / 3));
        }

        private static void RunExerciseEight()
        {
            double a;

            Write("Input a decimal number: ");
            if (!double.TryParse(ReadLine(), out a))
            {
                WriteLine("You must input a decimal number.");
                return;
            }

            WriteLine("Square root: {0:0.00}", Math.Sqrt(a));
            WriteLine("Cube: {0:0.00}", Math.Pow(a, 2));
            WriteLine("Power 10: {0:0.00}", Math.Pow(a, 10));
        }

        private static void RunExerciseNine()
        {
            string name;
            DateTime birthdate;
            string dateFormat = "yy-MM-dd";

            Write("Hello, what is your name?: ");
            name = ReadLine();

            Write("Hello {0}, what is your birth date ({1})?: ", name, dateFormat);
            if (!DateTime.TryParseExact(
                ReadLine(),
                dateFormat,
                new CultureInfo("sv-SE"),
                DateTimeStyles.None,
                out birthdate))
            {
                WriteLine("You must input a date in the right format.");
                return;
            }

            string answer;
            bool hadBeer = false;
            bool isOfAge = birthdate.AddYears(18) < DateTime.Now;
            if (isOfAge)
            {
                Write("Do you want a beer? y/n: ");
                answer = ReadLine();
                if (answer.ToLower() == "y")
                {
                    WriteLine("Thankyou for your order.");
                    hadBeer = true;
                }
            }
            if (!hadBeer)
            {
                Write("Do you want a coke? y/n: ");
                answer = ReadLine();
                if (answer.ToLower() == "y")
                    WriteLine("Here is your coke.");
                else
                    WriteLine("No ther options are available.");
            }
        }
        private static void RunExerciseTen()
        {
            ResetColor();
            while (true)
            {
                Clear();
                Write(
                    "Choose what to do:\n" +
                    "1) Divide two numbers.\n" +
                    "2) Run exercise 4\n" +
                    "3) Switch console text color\n" +
                    "0) Exit\n" +
                    "> ");

                string menuChoice = ReadLine();

                Clear();
                switch (menuChoice)
                {
                    case "0":
                        ResetColor();
                        return;
                    case "1":
                        DivideNumbers();
                        break;
                    case "2":
                        RunExerciseFour();
                        break;
                    case "3":
                        if (ForegroundColor != ConsoleColor.Red)
                            ForegroundColor = ConsoleColor.Red;
                        else
                            ForegroundColor = ConsoleColor.Green;
                        continue;
                    default:
                        break;
                }

                Write("\nPress any key to coninue...");
                ReadKey();
            }

            void DivideNumbers()
            {
                double a, b;

                if (!TryReadNumber(out a))
                    return;

                if (!TryReadNumber(out b))
                    return;

                if (b != 0)
                    WriteLine("{0:0.###}", a / b);
                else
                    WriteLine("Cannot divide by zero.");
            }

            bool TryReadNumber(out double num)
            {
                Write("Input a number: ");
                if (!double.TryParse(ReadLine(), out num))
                {
                    WriteLine("You must input a number.");
                    return false;
                }
                return true;
            }
        }

        private static void RunExerciseEleven()
        {
            int num;

            Write("Enter a number above zero: ");

            if (!int.TryParse(ReadLine(), out num))
            {
                WriteLine("You must enter a number.");
                return;
            }

            if (num < 1)
            {
                WriteLine("You must enter a number above zero.");
                return;
            }

            for (int i = 1; i < num + 1; i++)
            {
                if (i % 2 == 0)
                    ForegroundColor = ConsoleColor.Red;
                else
                    ForegroundColor = ConsoleColor.Green;

                WriteLine(i);
            }

            WriteLine("----------");

            for (int i = num; i > 0; i--)
            {
                if (i % 2 == 0)
                    ForegroundColor = ConsoleColor.Red;
                else
                    ForegroundColor = ConsoleColor.Green;

                WriteLine(i);
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

            WriteLine(buffer.ToString());
        }

        private static void RunExerciseThirteen()
        {
            Random random = new Random();

            int number = random.Next(1, 501);
            int guess;
            int guesses = 0;

            while (true)
            {
                Write("Guess {0} number: ",
                    guesses > 0 ? "another" : "a");

                if (!int.TryParse(ReadLine(), out guess))
                {
                    WriteLine("You must input a number");
                    continue;
                }

                guesses++;

                if (guess == number)
                {
                    WriteLine("Correct after {0} tries.", guesses);
                    return;
                }
                else if (guess < number)
                    WriteLine("Guess was too small.");
                else
                    WriteLine("Guess was too big.");
            }
        }

        private static void RunExerciseFourteen()
        {
            int total = 0;
            int i = 0;

            while (true)
            {
                Write("Enter a number: ");

                if (!int.TryParse(ReadLine(), out int num))
                {
                    WriteLine("You must input a number");
                    continue;
                }

                if (num == -1)
                {
                    if (i > 0)
                    {
                        WriteLine("Sum: {0}", total);
                        WriteLine("Mean: {0}", total / i);
                    }
                    return;
                }


                total += num;
                i++;

            }
        }

        private static void RunExerciseFifteen()
        {
            // Part 1
            int num = ReadNumber<int>();
            for (int i = num / 2; i > 1; i--)
            {
                if (num % i == 0)
                    Write($"{i}, ");
            }
            WriteLine(1);

            WriteLine("-------");

            // Part 2
            int sum;
            int outputs = 3;
            for (int i = 3; outputs > 0; i++)
            {
                sum = 0;
                for (int j = i / 2; j > 0; j--)
                {
                    if (i % j == 0)
                        sum += j;
                }

                if (i == sum)
                {
                    WriteLine(sum);
                    outputs--;
                }
            }
        }

        /********************************************************************
         * Non-exercise helper functions
         */

        private static T ReadNumber<T>(
            string msg = "Input a number: ",
            string err = "You must input a number: "
            )
        {
            T num;
            string input;

            TypeConverter converter = TypeDescriptor.GetConverter(typeof(T));

            Write($"{msg}");
            while (true)
            {
                input = ReadLine();
                try
                {
                    num = (T)converter.ConvertFromString(input);
                    return num;
                }
                catch
                {
                    Write($"{err}");
                }
            }
        }
    } // class
} // namespace
