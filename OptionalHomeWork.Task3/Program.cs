namespace OptionalHomeWork.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Trapezoid trapezoid = new Trapezoid(-4,0,2,1,3,-1,-1.4,-5.2);

            trapezoid.LongSide();
            trapezoid.Isosceles();
            trapezoid.Height();
            trapezoid.Square();
            trapezoid.Perimetr();
            trapezoid.Print();

        }
    }
}