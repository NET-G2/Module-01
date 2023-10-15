namespace Lesson03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = null;
            List<int> numbers1 = new List<int>()
            {
                1, 2, 3, 4
            };

            var res = numbers?.Except(numbers1);
            var res2 = numbers1.Except(numbers);
        }
    }
}