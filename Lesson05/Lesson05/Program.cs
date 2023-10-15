namespace Lesson05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int firstNumber = int.Parse(Console.ReadLine());
            //int secondNumber = int.Parse(Console.ReadLine());
            //int thirdNumber = int.Parse(Console.ReadLine());

            //CalculateSum(1, firstNumber, secondNumber, thirdNumber);

            //int a = 2;
            //int b = a;

            //b = 5;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int a;
            //AddOne(out a);
            //Console.WriteLine(a);

            // Reference type 
            //A a = new A();
            //a.x = 1;

            //AddOne(a);
            //Console.WriteLine(a.x);
            //AddTwo(a);
            //Console.WriteLine(a.x);

            //A b = a;

            //b.x = 2;
            //Console.WriteLine(a.x);

            //b = new A();
            //b.x = 5;
            //Console.WriteLine(a.x);

            // ** string **
            //string str = "Salom!";
            //string str1 = str;
            //str1 = "Hello";
            //char ss = str1[0];

            ////str[0] = "a";
            //str1 = str1 + "World";
            //Console.WriteLine(str);
            //Console.WriteLine(str1);

            //Stopwatch stopwatch = new Stopwatch();
            //StringBuilder builder = new StringBuilder();
            //stopwatch.Start();

            //for (int i = 0; i < 100000; i++)
            //{
            //    builder.Append(i);
            //}

            //Console.WriteLine(builder);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.Elapsed.ToString());
            //A a = new A();
            //A b = new A();

            //a.x = 5;

            //string str = "Hello";
            //string str1 = "Hello1";

            // Console.WriteLine("{0} Dunyo {1}", "Hello", "!");

            //string str = "hhh eee  Hello world hhh hh sphace! eee hhh";
            //bool endsWithO = str.EndsWith("o");
            //bool endsWithS = str.EndsWith("s");
            //bool startsWithO = str.StartsWith("o");
            //bool startsWithH = str.StartsWith("s");
            //bool containsE = str.Contains("world");
            //bool containsS = str.Contains("s");
            //bool containsCaseInsensitive = str.ToLower().Contains("hello");
            //char c = str[0];
            //char las = str[^1];
            //int index = str.LastIndexOf('l');
            //string newStr = str.Remove(0, index);
            //var s = str.Append('c');


            //Console.WriteLine(newStr);
            //Console.WriteLine(endsWithO);
            //Console.WriteLine(endsWithS);
            //Console.WriteLine(startsWithO);
            //Console.WriteLine(startsWithH);

            //str.Substring(0, 5);
            //str.Replace('h', 'H');
            //char[] charsToRemove = new char[]
            //{
            //    ' ', 'e', 'h'
            //};
            //string trimmed = str.Trim(' ', 'e', 'h');
            //Console.WriteLine($"trimmed: {trimmed}");

            Dictionary<int, int> pairs = new Dictionary<int, int>();
            Random random = new Random();
            List<int> existing = new List<int>();

            for (int i = 1; i <= 23; i++)
            {
                while (true)
                {
                    var val = random.Next(1, 24);
                    if (val != i && !existing.Contains(val))
                    {
                        pairs.Add(i, val);
                        existing.Add(val);
                        break;
                    }
                }
            }

            foreach (var kvp in pairs)
            {
                Console.WriteLine($"  {kvp.Key} -> {kvp.Value}");
            }

            //existing.Sort();
            //int d = 0;
            //foreach (var kvp in pairs)
            //{
            //    Console.WriteLine($"{kvp.Key} -> {kvp.Value} -> {existing[d]}");
            //    d++;
            //}
        }

        public static void AddOne(A a)
        {
            int b = 5;
            a.x += b;
            A c = new A();

            Console.WriteLine(a.x);
        }

        public static void AddTwo(A a)
        {
            a.x = 6;
            Console.WriteLine(a.x);
        }

        public static int Min(int a, int b)
        {
            return a < b ? a : b;
        }

        public static int Min(ref int a, int b)
        {
            return a < b ? a : b;
        }

        public static int Min(int a, out int b)
        {
            b = 1;
            return a < b ? a : b;
        }

        public static void AddOne(int a)
        {
            a += 1;
            Console.WriteLine(a);
        }

        //public static void CalculateSum(int a, int[] numbers)
        //{
        //}

        public static void CalculateSum(int a, params int[] numbers)
        {

        }

        //public static void CalculateSum(int a, int b, int c, int d)
        //{

        //}

        //public static void CalculateSum(int a, int b, int c, int d, int e)
        //{

        //}
    }

    public class A
    {
        public int x;
    }
}