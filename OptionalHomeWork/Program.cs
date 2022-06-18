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

            var union = new Fractions();

            Console.WriteLine("Demonstration");
            Console.WriteLine($"SUM:{union.Sum(fractions1, fractions2):0.####}");
            Console.WriteLine($"Substraction:{union.Substraction(fractions1, fractions2):0.####}");
            Console.WriteLine($"Multiplication:{union.Multiplication(fractions1, fractions2):0.####}");
            Console.WriteLine($"HighNumber:{union.HighNumber(fractions1, fractions2):0.####}");








        }



    }
}