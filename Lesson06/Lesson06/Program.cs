namespace Lesson06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] arr = new int[input];

            int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    arr[index++] = i;
                    Console.WriteLine(arr[i]);
                }
            }

            //Price price = new Price();
            //price.value = 100;62

            //Car car = new Car();
            //car.price = price;

            //Car car2 = car;
            //car2.price.value = 50;

            //Price price = new Price();
            //price.value = 500;

            //Car car = new Car();
            //Car car1 = new Car();
            //Car car2 = new Car();
            //Car car3 = new Car();
            //Car car4 = new Car();

            //Car[] cars = new Car[]
            //{
            //    car, car1, car2, car3, car4
            //};
            //int mainPrice = 500;
            //for (int i = 0; i < cars.Length; i++)
            //{
            //    cars[i].price = mainPrice;
            //}

            // mainPrice = 400;

            int a = 5;
            Car[] numbers = new Car[5];

            //DoSomething(numbers);

            //int[] number1 = new int[]
            //{
            //    1, 2, 3, 4,
            //};
            //int[] numbers2 =
            //{
            //    1, 2, 3, 4,
            //};

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = new Car();
            //    Console.WriteLine(numbers[i].PricePrice.value);
            //}

            GetMaxSequence();
        }

        static void DoSomething(int[] arr)
        {
            arr[0] = 500;
        }

        static void GetMaxSequence()
        {
            int previousNumber;
            int currentNumber;
            int currentSequence = 0;
            int maxNumber = 0;
            int maxSequence = 0;

            currentNumber = int.Parse(Console.ReadLine());
            previousNumber = currentNumber;
            currentSequence++;
            maxNumber = currentNumber;
            maxSequence = currentSequence;

            while (int.TryParse(Console.ReadLine(), out int input))
            {
                if (input == 0)
                {
                    break;
                }

                currentNumber = input;

                if (currentNumber == previousNumber)
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxSequence)
                    {
                        maxNumber = previousNumber;
                        maxSequence = currentSequence;
                    }

                    currentSequence = 1;
                }

                previousNumber = currentNumber;
            }

            Console.WriteLine($"Max sequence is: {maxSequence} with number: {maxNumber}");
        }
    }

    class Car
    {
        public int price;
        public Price PricePrice;
    }

    class Price
    {
        public int value;
    }
}