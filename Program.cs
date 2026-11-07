namespace cs1_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            /*Console.Write("Enter a number (1-100): ");
            int num = int.Parse(Console.ReadLine());
            if (num < 1 || num > 100)
            {
                Console.WriteLine("Error!");
            }
            else if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(num);
            }*/

            //2
            /*Console.Write("Enter a number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter percentage: ");
            double num2 = double.Parse(Console.ReadLine());
            double result = num1 * num2 / 100;
            Console.WriteLine("Result: " + result);*/

            //3
            /*Console.Write("Enter first digit: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second digit: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter third digit: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Enter fourth digit: ");
            int d = int.Parse(Console.ReadLine());
            int result1 = a * 1000 + b * 100 + c * 10 + d;
            Console.WriteLine(result1);*/

            //4
            /*Console.Write("Enter a six-digit number: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 100000 || n > 999999)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Console.Write("Enter first pos 1 to 6: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second pos to 6: ");
                int n2 = int.Parse(Console.ReadLine());
                if (n1 < 1 || n1 > 6 || n2 < 1 || n2 > 6)
                {
                    Console.WriteLine("Error!");
                }
                else
                {
                    int[] digits = new int[6];
                    for (int i = 5; i >= 0; i--)
                    {
                        digits[i] = n % 10;
                        n /= 10;
                    }
                    int tem = digits[n1 - 1];
                    digits[n1 - 1] = digits[n2 - 1];
                    digits[n2 - 1] = tem;
                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write(digits[i]);
                    }
                }
            }*/

            //5

            //6
            /*Console.WriteLine("1. Fahrenheit to Celsius \n2. Celsius to Fahrenheit");
            Console.Write("Choose: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Write("Enter temperature: ");
            double temp = double.Parse(Console.ReadLine());
            if (choice == 1)
            {
                double converted = (temp - 32) * 5 / 9;
                Console.WriteLine("Celsius: " + converted);
            }
            else if (choice == 2)
            {
                double converted = temp * 9 / 5 + 32;
                Console.WriteLine("Fahrenheit: " + converted);
            }
            else
            {
                Console.WriteLine("errorrrrrr");
            }
            //7
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 > number2)
            {
                int tempor = number1;
                number1 = number2;
                number2 = tempor;
            }
            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }*/

            //8
            /*Console.Write("Enter a number: ");
            int nu = int.Parse(Console.ReadLine());
            int temporary = nu;
            int count = 0;
            int sum = 0;
            while (temporary > 0)
            {
                count++;
                temporary /= 10;
            }
            temporary = nu;
            while (temporary > 0)
            {
                int digit = temporary % 10;
                int power = 1;
                for (int i = 0; i < count; i++)
                {
                    power *= digit;
                }
                sum += power;
                temporary /= 10;
            }
            if (sum == nu && nu >= 0)
            {
                Console.WriteLine("Armstrong!!");
            }
            else
            {
                Console.WriteLine("Nope");
            }*/

            //9
            Console.Write("Enter a number: ");
            int chislo = int.Parse(Console.ReadLine());
            int summ = 0;
            for (int i = 1; i < chislo; i++)
            {
                if (chislo % i == 0)
                {
                    summ += i;
                }
            }
            if (summ == chislo && chislo > 1)
            {
                Console.WriteLine("Perfect number");
            }
            else
            {
                Console.WriteLine("Not a perfect number");
            }
        }
    }
}
