namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string str = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    sum +=

                 Convert.ToInt32(str[i].ToString());
                }
                
            }
            Console.WriteLine(sum);*/
            int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int k = 2;
            Console.WriteLine("kiritilgan k sonini massivning asosoiy va yordamchi diagonaliga ko`paytirishdan hosil bo`lgan massiv elementlari :");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (i == j || i + j == array.GetLength(0) - 1)
                    {
                        Console.Write(array[i, j] * k + " ");
                    }
                    else
                    {
                        Console.Write(array[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}