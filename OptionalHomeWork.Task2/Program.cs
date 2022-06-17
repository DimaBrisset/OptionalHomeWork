using System;

namespace OptionalHomeWork.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();


            Money money1 = new Money(random.Next(-100, 100), RandomByte[100]);
            money1.CreativeCardBalance();
            Console.WriteLine(money1.ToString());

            Money money2 = new Money(random.Next(-100, 100), random.Next(1, 200));
            money2.CreativeCardBalance();
            Console.WriteLine(money2.ToString());

            Console.WriteLine($"SUM: {Sum(money1, money2):0.####}");
            Console.WriteLine($"Substraction: {Substraction(money1, money2):0.####}");
            Console.WriteLine($"Multiplication: {Multiplication(money1, money2):0.####}");
            Console.WriteLine($"HighNumber: {HighNumber(money1, money2):0.####}");

      
        }

        static decimal Sum(Money a, Money b)
        {
            return a.CreativeCardBalance() + b.CreativeCardBalance();
        }

        static decimal Substraction(Money a, Money b)
        {
            return a.CreativeCardBalance() / b.CreativeCardBalance();
        }

        static decimal Multiplication(Money a, Money b)
        {
            return a.CreativeCardBalance() * b.CreativeCardBalance();
        }

        static decimal HighNumber(Money a, Money b)
        {
            return Math.Max(a.CreativeCardBalance(), b.CreativeCardBalance());
        }

        static byte[]  RandomByte()
        {
            Random rnd = new Random();
            Byte[] b = new Byte[];
            rnd.NextBytes(b);

            return b;

        
        }


    }
}