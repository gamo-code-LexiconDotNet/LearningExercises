using System;

namespace LearningExercises
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or 0 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1: RunExerciseOne(); break;
                        case 2: RunExerciseTwo(); break;
                        case 3: RunExerciseThree(); break;
                        case 4: RunExerciseFour(); break;
                        case 5: RunExerciseFive(); break;
                        case 6: RunExerciseSix(); break;
                        case 7: RunExerciseSeven(); break;
                        case 8: RunExerciseEight(); break;
                        case 9: RunExerciseNine(); break;
                        case 10: RunExerciseTen(); break;
                        case 11: RunExerciseEleven(); break;
                        case 12: RunExerciseTwelve(); break;
                        case 13: RunExerciseThirteen(); break;
                        case 14: RunExerciseFourteen(); break;
                        case 15: RunExerciseFifteen(); break;
                        case 16: RunExerciseSixteen(); break;
                        case 17: RunExerciseSeventeen(); break;
                        case 18: RunExerciseEighteen(); break;
                        case 19: RunExerciseNineteen(); break;
                        case 20: RunExerciseTwenty(); break;
                        case 21: RunExerciseTwentyOne(); break;
                        case 0: keepAlive = false; break;
                        default:
                            Console.ForegroundColor= ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!.");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }
    }
}
