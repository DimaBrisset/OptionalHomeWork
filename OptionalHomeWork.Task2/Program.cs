using System;

namespace OptionalHomeWork.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var firstNumber = random.Next(0, 1000000);
            var secondNumber = ByteRandom();


            Money money1 = new Money(firstNumber, secondNumber);
            money1.CreativeNumber();
            money1.Print();

            Money money2 = new Money(firstNumber, secondNumber);
            money2.CreativeNumber();
            money2.Print();


            Money money=new Money();
            money = money1 + money2;
            Console.WriteLine(money.ToString());

           
           





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