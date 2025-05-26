using System.Threading.Channels;

namespace ControlStructure_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter POSITIVE numbers (Negative numbers to STOP):");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number >= 0)
            {
                sum += number;
                number = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"SUM IS: {sum}");
            //***
            for (int a = 10; a <= 20; a++)
            {
                if (a % 2 == 0 && a % 3 == 0)
                {
                    Console.WriteLine($"NUMBER IS: {a}");
                    break;
                }
            }
            //***
            int i = 0;
            while (i < 10)
            {
                i++;

                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            //***
            string Password = "0909101";
            string password = "";
            int attempt = 0;
            do
            {
                Console.WriteLine("Please Enter PASSWORD: ");
                password = Console.ReadLine();
                attempt++;

                if (password == Password)
                {
                    Console.WriteLine("WELCOME!");
                    break;
                }
                else
                {
                    Console.WriteLine("password is INCORRECT.");
                }
            }
            while (attempt < 3);

            if (password != Password)
            {
                Console.WriteLine("You Are NOT Logged in.");
            }
            //***
            int choice;
            do
            {
                Console.WriteLine("PLEASE ENTER NUMBER 1 to 3: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                    break;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello User!");
                        break;
                    case 2:
                        Console.WriteLine($"today is: {DateTime.Now.ToShortDateString()}");
                        break;
                    case 3:
                        Console.WriteLine("Have a good day!");
                        break;
                    default:
                        Console.WriteLine("Invalid value");
                        break;
                }
            } while (true);

            Console.WriteLine("Program is OVER.");
            //***
            Console.WriteLine("Please Enter a NUMBER: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            while (Number > 0)
            {
                Console.WriteLine(Number);
                Number--;
            }
            //***
            Console.WriteLine("Please Enter a NUMBER: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(number1);
                number1--;
            }
            while (number1 > 0);
            //***
            Console.WriteLine("Please Enter a NUMBER: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            
            int result = 1;
            int b = 1;
            do
            {
                result *= b;
                b++;
            }
            while (b <= number2);
            Console.WriteLine($"Factorial {number2} = {result}");
            //***
            Random random = new Random();
            int secret = random.Next(1, 101);
            int guess;

            Console.WriteLine("Guess a number between 1 and 100:");

            while (true)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secret)
                {
                    Console.WriteLine("CORRECT!");
                    break;
                }
                else if (guess < secret)
                {
                    Console.WriteLine("Go Upper");
                }
                else
                {
                    Console.WriteLine("Go Lower");
                }
                //***
                int c = 1;

                while (c <= 50)
                {
                    if (c % 7 != 0)
                    {
                        c++;
                        continue;
                    }

                    Console.WriteLine(c);
                    c++;
                }
                //***
                for (int d = 1; d <= 5; d++)
                {
                    for (int j = 1; j <= d; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                //***
                int rows = 3;

                for (int e = 1; e <= rows; e++)
                {

                    for (int space = 1; space <= rows - e; space++)
                    {
                        Console.Write(" ");
                    }


                    for (int star = 1; star <= 2 * e - 1; star++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
