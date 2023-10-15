namespace Lesson04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Flow control

            ////Console.WriteLine("Enter your age");

            ////int age = int.Parse(Console.ReadLine());

            ////if (age < 18)
            ////{
            ////    Console.WriteLine("You are not allowed to enter.");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("You are allowed to enter.");
            ////}

            ////string language = Console.ReadLine();

            ////if (language == "uz")
            ////{
            ////    Console.WriteLine("Salom!");
            ////}
            ////else if (language == "ru")
            ////{
            ////    Console.WriteLine("Привет!");
            ////}
            ////else if (language == "en")
            ////{
            ////    Console.WriteLine("Hello!");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Language is not defined.");
            ////}

            ////// Nested if
            ////if (language == "uz")
            ////{
            ////    if (age < 18)
            ////    {
            ////        Console.WriteLine("You are not allowed to receive a driver license.");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("You are allowed to receive a driver license.");
            ////    }
            ////}

            ////// Multiple conditions
            ////if (language == "en" && age < 20)
            ////{
            ////    Console.WriteLine("You are not allowed to receive a driver license.");
            ////}
            ////else if (language == "en" && age >= 20)
            ////{
            ////    Console.WriteLine("You are allowed to receive a driver license.");
            ////}

            ////if (age >= 16 && (language == "ru" || language == "en"))
            ////{
            ////    Console.WriteLine("You are allowed to receive a driver license.");
            ////}

            ////Console.WriteLine("Enter temperature in celcius:");
            ////int temperature = int.Parse(Console.ReadLine());
            ////string message = temperature < 15 ? "Cold!" : "Awesome!!!";

            ////Console.WriteLine($"Today's temperature {message}.");

            ////switch (message)
            ////{
            ////    case "Cold!":
            ////        Console.WriteLine("It's cold today");
            ////    case "Awesome!!!":
            ////        Console.WriteLine("It's awesome weather today");
            ////        break;
            ////    default:
            ////        Console.WriteLine("Unknown weather.");
            ////        break;
            ////}

            //#endregion

            //#region Iterative statements

            //// For
            ////int sum = 0;
            ////for (int i = 0; (true && false && true); i++)
            ////{
            ////    sum += i;
            ////    Console.WriteLine(sum);
            ////}

            //Boshlanish:
            //    int sum = int.Parse(Console.ReadLine());

            //    if (sum == 2)
            //    {
            //        goto BirinchiGoTo;
            //    }

            //BirinchiGoTo:

            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (sum == 4)
            //            continue;

            //        sum += i;
            //        Console.WriteLine(sum);
            //    }

            //    if (sum == 5)
            //    {
            //        goto Boshlanish;
            //    }

            //    while (sum < 100)
            //    {
            //        sum *= 2;
            //    }

            //    do
            //    {
            //        sum++;
            //    } while (sum > 0);

            //    #endregion

            string message = "Hello!";

            PrintMessage(message);
            Console.WriteLine(message);
            PrintMessage(ref message);
            Console.WriteLine(message);

            int a = 0;
            Calc(a);
            Console.WriteLine(a);
            Calc(out a);
            Console.WriteLine(a);
        }

        public static void Calc(int number)
        {
            number += 10;
        }

        public static void Calc(out int number)
        {

        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine($"Bugun 27-03-2023. {message}");
            message = "Salom!";
        }

        public static void PrintMessage(ref string message)
        {
            Console.WriteLine($"Bugun 27-03-2023. {message}");
        }

        //public static void Calculate(out int number)
        //{

        //}

        public static void CalculateTwoNumbers(int firstNumber, int secondNumber)
        {

            if (firstNumber == 0)
            {
                return;
            }

            if (firstNumber > secondNumber)
            {
                PrintMessage("First number is greater.");
            }
            else
            {
                PrintMessage("Second number is greater or equal.");
            }
        }

    }
}