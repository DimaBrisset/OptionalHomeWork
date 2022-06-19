namespace OptionalHomeWork.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomDouble = random.NextDouble();

            Money money1 = new Money(random.Next(0, 1000000), ByteRandom());
            money1.CreativeNumber();
            money1.Print();

            Money money2 = new Money(random.Next(0, 1000000), ByteRandom());
            money2.CreativeNumber();
            money2.Print();

            Console.WriteLine($"RandomDouble: {randomDouble}\n");

            Money money = new Money();


            Console.WriteLine("Demonstration");
            Console.WriteLine($"SUM:{money.Sum(money1, money2)}");
            Console.WriteLine($"Substraction:{money.Substraction(money1, money2)}");
            Console.WriteLine($"Multiplication:{money.Multiplication(money1, money2)}");
            Console.WriteLine($"Division:{money.Division(money1, money2)}");
            Console.WriteLine($"HighNumber:{money.HighNumber(money1, money2)}");

            Console.WriteLine(
                $"Multiplication FRACTIONAL:{money.Multiplication(money1, money2, (decimal)randomDouble)}");
            Console.WriteLine($"Division FRACTIONAL:{money.Division(money1, money2, (decimal)randomDouble)}");
        }

        public static byte ByteRandom()
        {
            Random rnd = new Random();
            Byte[] b = new Byte[10];
            rnd.NextBytes(b);

            return b[0];
        }
    }
}