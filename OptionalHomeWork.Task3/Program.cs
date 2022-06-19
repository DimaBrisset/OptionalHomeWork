namespace OptionalHomeWork.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareAvg = 0;
            double squareTrapez = 0;
            int isosceles = 0;


            Console.WriteLine("Введите к-во трапеций: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Trapezoid[] trapezoids = new Trapezoid[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                trapezoids[i] = new Trapezoid(r.Next(1, 5), r.Next(1, 5), r.Next(1, 5), r.Next(1, 5), r.Next(1, 5),
                    r.Next(1, 5), r.Next(1, 5), r.Next(1, 5));
                Console.WriteLine();
                Console.WriteLine("#" + i);
                trapezoids[i].Print();
                squareAvg += trapezoids[i].Square();

                if (trapezoids[i].Isosceles())
                {
                    isosceles++;
                }

                if (trapezoids[i].Square() > squareAvg / n)
                {
                    squareTrapez++;
                }
            }

            Console.WriteLine("____________________________");
            Console.WriteLine("Total Trapezoid:" + n);
            Console.WriteLine("Isosceles trapezoid: " + isosceles);
            //Console.WriteLine($"AVG  Square:" + squareAvg / n);
            Console.WriteLine("Square more > AVG Square.Was found: " + squareTrapez);
        }
    }
}