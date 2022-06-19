namespace OptionalHomeWork.Task3
{
    internal class Trapezoid
    {
        private double _x1;
        private double _y1;
        private double _x2;
        private double _y2;
        private double _x3;
        private double _y3;
        private double _x4;
        private double _y4;
        private double _longSideA;
        private double _longSideB;
        private double _longSideC;
        private double _longSideD;
        private double _isoscelesAC;
        private double _isoscelesBD;
        private double _height;
        private double _perimeter;
        private double _square;

        public Trapezoid(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            _x1 = x1;
            _x2 = x2;
            _y1 = y1;
            _y2 = y2;
            _x3 = x3;
            _y3 = y3;
            _x4 = x4;
            _y4 = y4;
        }

        public double LongSideA()
        {
            _longSideA = Math.Sqrt((Math.Pow((_x4 - _x1), 2)) + Math.Pow((_y4 - _y1), 2));
            return _longSideA;
        }

        public double LongSideB()
        {
            _longSideB = Math.Sqrt((Math.Pow((_x3 - _x2), 2)) + Math.Pow((_y3 - _y2), 2));
            return _longSideB;
        }

        public double LongSideC()
        {
            _longSideC = Math.Sqrt((Math.Pow((_x2 - _x1), 2)) + Math.Pow((_y2 - _y1), 2));
            return _longSideC;
        }

        public double LongSideD()
        {
            _longSideD = Math.Sqrt((Math.Pow((_x4 - _x3), 2)) + Math.Pow((_y4 - _y3), 2));
            return _longSideD;
        }

        public bool Isosceles()
        {
            _isoscelesAC = Math.Sqrt((Math.Pow((_x3 - _x1), 2)) + Math.Pow((_y3 - _y1), 2));
            _isoscelesBD = Math.Sqrt((Math.Pow((_x4 - _x2), 2)) + Math.Pow((_y4 - _y2), 2));

            if (_isoscelesAC == _isoscelesBD)
                return true;
            return false;
        }


        public double Height()
        {
            _height = 0.5 * (Math.Sqrt(4 * Math.Pow(_longSideC, 2) - Math.Pow(_longSideA - _longSideB, 2)));
            return _height;
        }

        public double Perimetr()
        {
            _perimeter = _longSideA + _longSideB + _longSideC + _longSideD;
            return _perimeter;
        }

        public double Square()
        {
            _square = ((_longSideA + _longSideB) / 2) * _height;
            return _square;
        }


        public void Print()
        {
            Console.WriteLine($"Coordinates: A({_x1};{_y1}) B({_x2};{_y2}) C({_x3};{_y3}) D({_x4};{_y4})");
            Console.WriteLine(
                $"Long: AD({LongSideA():0.###})  BC:({LongSideB():0.###}) AB:({LongSideC():0.###}) CD: ({LongSideD():0.###})");
            Console.WriteLine($"Isosceles:{Isosceles():0.###}");
            Console.WriteLine();
            Console.WriteLine($"Diagonal: AC:({_isoscelesAC:0.###}) BD:({_isoscelesBD:0.###}) ");
            Console.WriteLine($"Height:{Height()}");
            Console.WriteLine($"Perimetr:{Perimetr()}");
            Console.WriteLine($"Square:{Square()}");
            Console.WriteLine("____________________________");
        }
    }
}