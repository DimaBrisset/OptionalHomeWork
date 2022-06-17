using System;

namespace OptionalHomeWork.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Fractions fractions1 = new Fractions(random.Next(-100, 100), random.Next(1, 200));
            fractions1.CreativeNumber();
            Console.WriteLine(fractions1.ToString());

            Fractions fractions2 = new Fractions(random.Next(-100, 100), random.Next(1, 200));
            fractions2.CreativeNumber();
            Console.WriteLine(fractions2.ToString());

            Console.WriteLine($"SUM: {Sum(fractions1, fractions2):0.####}");
            Console.WriteLine($"Substraction: {Substraction(fractions1, fractions2):0.####}");
            Console.WriteLine($"Multiplication: {Multiplication(fractions1, fractions2):0.####}");
            Console.WriteLine($"HighNumber: {HighNumber(fractions1, fractions2):0.####}");


        }

        static decimal Sum(Fractions a, Fractions b)
        {
            return a.CreativeNumber() + b.CreativeNumber();
        }

        static decimal Substraction(Fractions a, Fractions b)
        {
            return a.CreativeNumber() / b.CreativeNumber();
        }

        static decimal Multiplication(Fractions a, Fractions b)
        {
            return a.CreativeNumber() * b.CreativeNumber();
        }

        static decimal HighNumber(Fractions a, Fractions b)
        {
            return Math.Max(a.CreativeNumber(), b.CreativeNumber());
        }
    }
}