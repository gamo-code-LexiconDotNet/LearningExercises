using System.ComponentModel;
using static System.Console;

namespace LearningExercises
{
    public partial class Program
    {
        private static T ReadNumber<T>(
            string msg = "Input a number: ",
            string err = "You must input a number: ")
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
    }
}
