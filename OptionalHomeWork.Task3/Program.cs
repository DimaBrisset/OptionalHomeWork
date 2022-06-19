namespace OptionalHomeWork.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

           // Trapezoid trd = new Trapezoid(-4,0,2,1,3,-1,-1.4,-5.2);

           



            Console.WriteLine("Введите к-во трапеций: "); int n = Convert.ToInt32(Console.ReadLine());
      
            Trapezoid[] trapezoids = new Trapezoid[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                trapezoids[i] = new Trapezoid(r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10), r.Next(1, 10));
                Console.WriteLine();
                Console.Write(i + " ");
                trapezoids[i].Print();
            }




        }
    }
}