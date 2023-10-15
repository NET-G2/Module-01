using System.Diagnostics;
using System.Text;

namespace Lesson08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int number1 = 0;
            //int number2 = 1;

            //Console.WriteLine(number1);
            //ChangeNumbers(ref number1);
            //Console.WriteLine(number1);


            // Class1.PrintSalam();
            // Console.WriteLine(Class1.PrintHello());
            // Console.WriteLine(GetMax(number1, number2));

            //int max = GetMax(GetMax(GetMax(2, 4), 5), GetMax(6, 7));
            //int max1 = GetMax(5, 6);
            //int max2 = GetMax(5, 7);

            //int input1 = int.Parse(Console.ReadLine());
            //int input2 = int.Parse(Console.ReadLine());
            //int[] array = new int[] { input1, input2 };

            //AddAll(array, "something");

            Stopwatch stopwatch = Stopwatch.StartNew();
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < 1000000; i++)
            {
                str.Append(i);
            }

            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        public static void ChangeNumbers(ref int number)
        {
            number = 20;
        }

        //public static int GetMax(int number, out int number2)
        //{
        //    Console.WriteLine($"{number} + {number2}");
        //    return Math.Max(number, number2);
        //}

        public static int AddAll(int[] numbers, string multiplier)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(multiplier);
                Console.WriteLine(numbers[i]);
            }

            return numbers.Length;
        }
    }

    class C
    {
        static void Do()
        {

        }
    }
}