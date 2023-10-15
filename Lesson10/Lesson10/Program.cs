namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ********
            // Task 1 *
            // ********

            //string str = Console.ReadLine();
            //int counter = 1;
            //char[] array = str.ToCharArray();

            //Array.Sort(array);

            //for (int i = 1; i < array.Length; i++)
            //{
            //    if (array[i] == array[i - 1])
            //    {
            //        counter++;
            //    }
            //    else
            //    {
            //        if (array[i] == ' ')
            //        {
            //            Console.WriteLine($"Bo'shliq - {counter}");
            //            counter = 1;
            //            continue;
            //        }
            //        Console.WriteLine($"{array[i - 1]} - {counter}");
            //        counter = 1;
            //    }
            //}

            // ********
            // Task 2 *
            // ********

            //Random random = new Random();
            //int sum = 0;
            //int[] array = new int[10];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = random.Next(-10, 10);
            //    sum += array[i];
            //    Console.Write($"{array[i]} ");
            //}

            //if (sum > array.Length)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            // ********
            // Task 3 *
            // ********

            //int leftDiagonalSum = 0;
            //int rightDiagonalSum = 0;

            //int[][] array = new int[5][];
            //Random random = new Random();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = new int[5];
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        array[i][j] = random.Next(0, 9);

            //        Console.Write($"{array[i][j]} ");
            //    }

            //    Console.WriteLine();
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array[i].Length; j++)
            //    {
            //        // Left diagonal sum
            //        if (i == j)
            //        {
            //            leftDiagonalSum += array[i][j];
            //        }

            //        // Last array sum
            //        if (i == array.Length - 1)
            //        {
            //            leftDiagonalSum += array[i][j];
            //        }

            //        // First array sum
            //        if (i == 0)
            //        {
            //            rightDiagonalSum += array[i][j];
            //        }

            //        // Right diagonal sum
            //        if (i + j == (array.Length - 1))
            //        {
            //            rightDiagonalSum += array[i][j];
            //        }
            //    }
            //}

            //Console.WriteLine($"Right diagonal: {rightDiagonalSum}");
            //Console.WriteLine($"Left diagonal: {leftDiagonalSum}");

            //if (rightDiagonalSum > leftDiagonalSum)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}

            // ********
            // Task 4 *
            // ********

            //string str = Console.ReadLine();
            //string[] strings = str.Split(' ');

            //for (int i = 0; i < strings.Length; i++)
            //{
            //    strings[i] = strings[i].Substring(0, 1).ToUpper()
            //        + strings[i].Substring(1);

            //    Console.Write($"{strings[i]} ");
            //}
        }
    }
}