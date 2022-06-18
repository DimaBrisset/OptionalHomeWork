using System;

namespace OptionalHomeWork.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Money money1 = new Money(random.Next(-100, 100), RandomByte());
            money1.CreativeNumber();
            Console.WriteLine(money1.ToString());

            Money money2 = new Money(random.Next(-100, 100), RandomByte());
            money2.CreativeNumber();
            Console.WriteLine(money2.ToString());

            var union = new Money();

            Console.WriteLine("Demonstration");
            Console.WriteLine($"SUM:{union.Sum(money1, money2):0.####}");
            Console.WriteLine($"Substraction:{union.Substraction(money1, money2):0.####}");
            Console.WriteLine($"Multiplication:{union.Multiplication(money1, money2):0.####}");
            Console.WriteLine($"HighNumber:{union.HighNumber(money1, money2):0.####}");

            Console.WriteLine(RandomByte());






        }
         public static byte RandomByte()
        {
            Random rnd = new Random();
            Byte[] b = new Byte[10];
            rnd.NextBytes(b);
            
            return b[0];
        
        }



    }
}