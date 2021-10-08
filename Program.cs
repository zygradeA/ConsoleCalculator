using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want to multiply, subtract, add, divide, self multiply or root? answer in lowercase");
            string c = Console.ReadLine();
            const double pi = 3.14159265358979326;
            Console.WriteLine("What equation do you want to do with pi?");
            string use_pi = Console.ReadLine();
            if (c == "no")
            {
                Console.WriteLine("Ok");
            }
            if (c == "multiply")
            {
                Console.WriteLine(a * b);
            }
            if (c == "subtract")
            {

                Console.WriteLine(a - b);
            }

            if (c == "add")
            {
                Console.WriteLine(a + b);
            }
            if (c == "divide")
            {
                Console.WriteLine(a / b);
            }
            if (c == "self multiply")
            {
                Console.WriteLine(Math.Pow(a, b));
            }
            if (c == "root")
            {
                Console.WriteLine(Math.Pow(a, 1 / b));
                
            }
            if (use_pi == "no")
            {
                Console.WriteLine("Ok");
            }
            if (use_pi == "area of circle")
            {
                Console.WriteLine(pi * Math.Pow(a, 2));
            }
            if (use_pi == "circumference")
            {
                Console.WriteLine(pi * (2 * a));
            }
            if (use_pi == "volume of circle")
            {
                Console.WriteLine(pi * Math.Pow(a, 2) * b);
            }
            if (use_pi == "volume of sphere")
            {
                Console.WriteLine(4 / 3 * pi * Math.Pow(a, 3));
            }
        }
    }
}
