using System;
using System.Globalization;
using System.IO;
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

            WriteLine($"Hello {firstName} {lastName}! I’m glad to inform "
                + "you that you are the test subject of my very first "
                + "assignment!");
        }

        private static void RunExerciseTwo()
        {
            var today = DateTime.Today;
            var tomorrow = today.AddDays(1);
            var yesterday = today.AddDays(-1);

            WriteLine("Todays date is {0}.", 
                today.ToShortDateString());
            WriteLine("Tomorrows date is {0}.", 
                tomorrow.ToShortDateString());
            WriteLine("Yesterdays date was {0}.", 
                yesterday.ToShortDateString());
        }

        private static void RunExerciseThree()
        {
            Write("Enter your first name: ");
            var firstName = ReadLine();
            Write("Enter your last name: ");
            var lastName = ReadLine();

            WriteLine($"Your full name is {firstName} {lastName}");
        }

        private static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG";

            WriteLine(
                str
                .Replace("quick", "brown")
                .Insert(str.IndexOf("DOG"), "lazy ")
                .ToLower()
                .Substring(1)
                .Insert(0, str[0].ToString())
                );
        }

        private static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, " +
                "they look something like: [1,2,3,4,5]";

            WriteLine(
                str
                .Insert(str.Length - 1, ",6,7,8,9,10")
                .Substring(str.IndexOf("["))
                .Replace("2,3,", "")
                );
        }

        private static void RunExerciseSix()
        {
            Write("Input an integer: ");
            if (!int.TryParse(ReadLine(), out int a))
            {
                WriteLine("You must input a number.");
                return;
            }

            Write("Input another integer: ");
            if (!int.TryParse(ReadLine(), out int b))
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
            Write("Input a radius: ");
            if (!double.TryParse(ReadLine(), out double r))
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
            Write("Input a decimal number: ");
            if (!double.TryParse(ReadLine(), out double a))
            {
                WriteLine("You must input a decimal number.");
                return;
            }

            WriteLine("Square root: {0:0.00}", Math.Sqrt(a));
            WriteLine("Square: {0:0.00}", Math.Pow(a, 2));
            WriteLine("Power 10: {0:0.00}", Math.Pow(a, 10));
        }

        private static void RunExerciseNine()
        {
            
            string dateFormat = "yy-MM-dd";

            Write("Hello, what is your name?: ");
            string name = ReadLine();

            Write("Hello {0}, what is your birth date ({1})?: ", 
                name, dateFormat);
            if (!DateTime.TryParseExact(
                ReadLine(),
                dateFormat,
                new CultureInfo("sv-SE"),
                DateTimeStyles.None,
                out DateTime birthdate))
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
                    WriteLine("Thank you for your order.");
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
                    WriteLine("We do not have anything else.");
            }
        }
        private static void RunExerciseTen()
        {
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

                Write("\nPress any key to continue...");
                ReadKey();
            }

            void DivideNumbers()
            {
                if (!TryReadNumber(out double a))
                    return;

                if (!TryReadNumber(out double b))
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
            Write("Enter a number above zero: ");
            if (!int.TryParse(ReadLine(), out int num))
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
            int number = random.Next(1, 501);
            int guesses = 0;

            while (true)
            {
                Write("Guess {0} number: ",
                    guesses > 0 ? "another" : "a");

                if (!int.TryParse(ReadLine(), out int guess))
                {
                    WriteLine("You must input a number");
                    continue;
                }

                guesses++;

                if (guess == number)
                {
                    WriteLine($"Correct after {guesses} tries.");
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

        private static void RunExerciseSixteen()
        {
            int num = ReadNumber<int>();

            int a = 0;
            int b = 1;
            int next = 1;
            for (int i = 0; i < num; i++)
            {
                Write("{0}{1}", a, i < num - 1 ? ", ": "");
                a = b;
                b = next;
                next = a + b;
            }
            WriteLine();
        }

        private static void RunExerciseSeventeen()
        {
            Write("Input a word or sentence: ");
            string input = ReadLine().ToLower().Replace(" ", "");

            for (int i = 0, j = input.Length - 1; i < j; i++, j--)
            {
                if (input[i] != input[j])
                {
                    WriteLine("Not a palindrome.");
                    return;
                }
            }
            WriteLine("Palindrome.");
        }

        private static void RunExerciseEighteen()
        {
            int length = ReadNumber<int>("How many numbers: ");
            int range = length * length + 1;
            int rlen = range.ToString().Length;

            int[] denominator = new int[length];
            double[] quota = new double[length];

            for (int i = 0; i < length; i++)
                denominator[i] = random.Next(-range, range);

            for (int i = 0; i < length; i++)
                quota[i] = 1.0 / denominator[i];

            string format = 
                "{0," + (rlen + 3) + ":0." + "".PadLeft(rlen, '0') + "}";
            foreach (double q in quota)
                WriteLine(format, q);
        }

        private static void RunExerciseNineteen()
        {
            // Must be in order high to low
            int[] coinDenominations = {
                1000, 500, 100, 50, 20, 10, 5, 1
            };

            int amountToPay = random.Next(1, coinDenominations[0] * 3 + 1);
            WriteLine($"Amount to pay: {amountToPay}");

            int amountHandedOver = ReadNumber<int>("Amount handed over: ");

            int calculatedChange = amountHandedOver - amountToPay;
            if (calculatedChange < 0)
            {
                WriteLine("Not enough coins.");
                return;
            } else if (calculatedChange == 0)
            {
                WriteLine("No change.");
                return;
            }
            WriteLine($"Calculated change: {calculatedChange}");

            WriteLine("Coin denomination distribution:");
            int denominationCount = 0;
            for (int i = 0; i < coinDenominations.Length; i++)
            {
                int qoutient = calculatedChange / coinDenominations[i];
                calculatedChange -= coinDenominations[i] * qoutient;
                denominationCount += qoutient;
                
                WriteLine("{0} coins = {1}", coinDenominations[i], qoutient);
            }
            WriteLine($"Denomination count: {denominationCount}");
        }

        private static void RunExerciseTwenty()
        {
            int length = random.Next(10, 21);
            int[] array1 = new int[length];
            int[] array2 = new int[length];

            for (int i = 0; i < length; i++)
                array1[i] = random.Next(1, length * length + 1);

            int left = 0;
            int right = length - 1;
            for (int i = 0; i < length; i++)
            {
                if (array1[i] % 2 == 0)
                    array2[right--] = array1[i];
                else
                    array2[left++] = array1[i];
            }

            WriteLine(string.Join(", ", array1));
            WriteLine(string.Join(", ", array2));
        }

        private static void RunExerciseTwentyOne()
        {
            int[] numbers = ReadCommaSeparatedNumbers();

            WriteLine(string.Join(", ", numbers));
            WriteLine("Min: {0}", Min(numbers));
            WriteLine("Max: {0}", Max(numbers));
            WriteLine("Mean: {0:0.###}", Mean(numbers));

            static int Min(int[] array)
            {
                int min = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] < min)
                        min = array[i];
                return min;
            }

            static int Max(int[] array)
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > max)
                        max = array[i];
                return max;
            }

            static double Mean(int[] array)
            {
                int sum = 0;
                for (int i = 1; i < array.Length; i++)
                    sum += array[i];
                return sum / (double)array.Length;
            }
        }

        private static void RunExerciseTwentyTwo()
        {
            string[] profanityList;
            try
            {
                string path = Environment.CurrentDirectory 
                    + "\\Profanity.txt";
                profanityList = File.ReadAllLines(path);
            }
            catch
            {
                WriteLine("Could not read from file.");
                return;
            }

            Write("Input words: ");
            string input = ReadLine();
 
            for (int i = 0; i < profanityList.Length; i++)
            {
                if (input.Contains(profanityList[i]))
                {
                    string pfnty = profanityList[i];
                    int len = pfnty.Length;
                    string sanitized = 
                        pfnty[0]
                        + "".PadLeft(len - 2, '*')
                        + pfnty[len - 1];
                    input = input.Replace(pfnty, sanitized);
                }
            }

            WriteLine(input);
        }

        private static void RunExerciseTwentyThree()
        {
            int[] array = new int[7];

            int i = 0;
            int rnd;
            while (i < 7)
            {
                rnd = random.Next(1, 41);

                if (Contains(array, rnd, i))
                    continue;

                array[i++] = rnd;
            }
            WriteLine(String.Join(", ",array));

            static bool Contains(int[] array, int rnd, int i)
            {
                for (int j = 0; j < i; j++)
                    if (array[j] == rnd)
                        return true;
                return false;
            }
        }

        private static void RunExerciseTwentyFour()
        {
            int[] deck = new int[0];
            int[] drawn = new int[0];

            FillDeck(ref deck);
                WriteLine(String.Join(",", deck));
            ShuffleCards(ref deck);
                WriteLine(String.Join(",", deck));
            PutCard(ref drawn, DrawCard(ref deck));
                WriteLine(String.Join(",", drawn));
                WriteLine(String.Join(",", deck));

            static int DrawCard(ref int[] deck)
            {
                int card = deck[^1];
                Array.Resize(ref deck, deck.Length - 1);
                return card;
            }

            static void ShuffleCards(ref int[] deck)
            {
                for (int i = 0; i < deck.Length * 4; i++)
                {
                    int rnd = random.Next(0, deck.Length);
                    int swap = deck[i % deck.Length];
                    deck[i % deck.Length] = deck[rnd];
                    deck[rnd] = swap;

                }
            }

            static void FillDeck(ref int[] deck)
            {
                Array.Resize(ref deck, 52);

                for (int i = 0, j = 1; i < deck.Length; i++)
                {
                    deck[i] = j;
                    if ((i + 1) % 4 == 0)
                        j++;
                }
            }

            static void PutCard(ref int[] deck, int card)
            {
                Array.Resize(ref deck, deck.Length + 1);
                deck[^1] = card;
            }
        }

        private static void RunExerciseTwentyFive()
        {
            int a = ReadNumber<int>();
            int b = ReadNumber<int>();

            try
            {
               WriteLine("{0}", a / b);
            } catch (DivideByZeroException ex)
            {
                WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }

        private static void RunExerciseTwentySix()
        {
            try
            {
                WriteLine(Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments));
                WriteLine(Environment.GetFolderPath(
                    Environment.SpecialFolder.MyPictures));
                WriteLine(Environment.GetFolderPath(
                    Environment.SpecialFolder.ProgramFilesX86));
                WriteLine(Environment.GetFolderPath(
                    Environment.SpecialFolder.Cookies));
                WriteLine(Environment.CurrentDirectory);

                File.Create(pathNamesDesktop).Close();
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.Message}");
            }
        }

        private static void RunExerciseTwentySeven()
        {
            try
            {
                StreamReader sr = new StreamReader(pathNamesLocal);
                while (!sr.EndOfStream)
                    WriteLine(sr.ReadLine());
                sr.Close();
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.Message}");
            }
        }

        private static void RunExerciseTwentyEight()
        {
            string[] names1 = { "Alice", "Bob", "Carol", "Dave", "Eve" };
            string[] names2 = { "Frank", "Grace", "Harry", "Irene", "John" };

            try
            {
                StreamWriter sw = new StreamWriter(pathNamesDesktop);
                foreach (string name in names1)
                {
                    sw.WriteLine(name);
                }
                sw.Close();

                sw = new StreamWriter(pathNamesDesktop, true);
                foreach (string name in names2)
                {
                    sw.WriteLine(name);
                }
                sw.Close();

                StreamReader sr = new StreamReader(pathNamesDesktop);
                while (!sr.EndOfStream)
                    WriteLine(sr.ReadLine());
                sr.Close();
            }
            catch (Exception ex)
            {
                WriteLine($"{ex.Message}");
            }
        }

        private static readonly string pathNamesDesktop = 
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
            + "\\Names.txt";

        private static readonly string pathNamesLocal = 
            Environment.CurrentDirectory + "\\Names.txt";

        private static readonly Random random = new Random();
    }
} 
