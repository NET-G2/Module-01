namespace Lesson07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] multiDimensional = { { 1, 2, 3 }, { 4, 5, 6 } };

            //int a = 5;
            //int[] array = { 1, a, 3 };

            //Change(array);

            //int[,] nums1;
            //int[,] nums2 = new int[2, 3];
            //int[,] nums3 = new int[2, 4] { { 0, 1, 2, 4 }, { 3, 4, 5, 4 } };
            //int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            //int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            //int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };

            //int[][] nums7 =
            //{
            //    new int[] {1, 3, 4, 5 },
            //    new int[] {1, 2, 3 },
            //    new int[] {2, 5, 8, 19, 10},
            //    new int[] {1, 3, 4, 5 },
            //    new int[] {1, 2, 3 },
            //    new int[] {2, 5, 8, 19, 10},
            //    new int[] {1, 3, 4, 5 },
            //    new int[] {1, 2, 3 },
            //    new int[] {2, 5, 8, 19, 10},
            //};

            //int[] g1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] g2 = new int[] { 6, 81, 2, 3 };
            //int[] g3 = new int[] { 6, 81, 2, 3, 99, 101 };

            //int[][] pdp =
            //{
            //    g1, g2, g3
            //};

            ////DisplayTwoDimension(nums3);
            ////DisplayJagged(nums7);
            //CreateArray();

            int[][] jaggedArray = new int[10][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[10];
            }

            int[] firstArray = jaggedArray[0];

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine(firstArray[i]);
            }
        }

        public static string[] GetNumber()
        {
            string[] arr = new string[] { "abc", "def", "ghi" };

            return arr;
        }

        public static void Change(int[] array)
        {

        }

        public static void FillArray(int[] array)
        {
            Random random = new Random();
            int rand;
            for (int i = 0; i < array.Length; i++)
            {
                rand = random.Next(0, 100);
                array[i] = rand;
            }

        }
        public static void FindMaxSumRow(int[] array)
        {

            int[][] arr1 = new int[5][];
        }

        public static void CreateArray()
        {
            Random random = new Random();
            int row = random.Next(1, 10);
            int[][] arr1 = new int[row][];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new int[random.Next(1, 10)];
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    arr1[i][j] = random.Next(1, 5);
                    Console.Write(arr1[i][j]);
                }
                Console.WriteLine();
            }

        }

        public static void DisplayTwoDimension(int[,] array)
        {
            //int rows = array.GetUpperBound(0) + 1;
            //int columns = array.Length / rows;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static void DisplayJagged(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}