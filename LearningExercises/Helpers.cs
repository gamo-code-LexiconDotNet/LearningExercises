using System;
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
            if (!IsNumeric(typeof(T)))
                throw new ArgumentException("Type of T must be numerical.");

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

        private static int[] ReadCommaSeparatedNumbers()
        {
            Write("Input comma separated numbers: ");
            string input;
            int[] numbers;

            while (true)
            {
                input = ReadLine();
                try
                {
                    numbers = Array.ConvertAll(input.Split(','), int.Parse);
                    break;
                }
                catch
                {
                    Write("Input only comma separated numbers: ");
                }
            }

            return numbers;
        }

        // from stackoverflow
        public static bool IsNumeric(Type type)
        {
            if (type == null)
                return false;

            if (type.IsGenericType 
                && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                type = type.GetGenericArguments()[0];
            }

            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Single:
                    return true;
                default:
                    return false;
            }
        }
    }
}
