namespace Lesson09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            // int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{

            //}

            #endregion

            #region Task2

            //int num = 113;
            //int sum = 0;
            //for (int i = 0; i < num;)
            //{
            //    sum += num % 10;
            //    num /= 10;
            //}

            //Console.WriteLine(sum);

            #endregion

            //string input = Console.ReadLine();
            //string result = "";
            //int counter = 1;

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    if (counter % 3 == 0)
            //    {
            //        result += ",";
            //    }

            //    result += input[(input.Length - 1) - i];

            //    counter++;
            //}

            //Console.WriteLine(result);

            #region Task3

            #endregion

            #region Task4

            #endregion

            #region Task5

            #endregion

            // MultiplyArray(GetRandomArray());

            GetRandomDoubleArray();
        }

        public static void MultiplyArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.Write($"{array[i] * array[0]} ");
                }
                else
                {
                    Console.Write($"{array[i] * array[array.Length - 1]} ");
                }
            }
        }

        public static int[] GetRandomArray()
        {
            Random random = new Random();
            int length = random.Next(1, 10);

            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }

            return array;
        }

        public static int[][] GetRandomDoubleArray()
        {
            Random random = new Random();
            int[][] array = new int[5][];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[5];

                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = random.Next(1, 10);
                    Console.Write($"{array[i][j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Diagonal - {251}");
            Console.WriteLine($"Last array sum - {123}");
            Console.WriteLine(true);
            return array;
        }
    }
}