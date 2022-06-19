namespace OptionalHomeWork.Task1
{
    internal class Fractions
    {
        public long _numberLong { get; set; }
        public int _numberInteger { get; set; }

        public Fractions()
        {
            _numberLong = 0;
            _numberInteger = 0;
        }

        public Fractions(long numberLong, int numberInteger)
        {
            _numberLong = numberLong;
            _numberInteger = numberInteger;
        }

        public decimal CreativeNumber()
        {
            string union = (_numberLong + "," + _numberInteger);
            decimal creativeNumber = Convert.ToDecimal(union);
            return creativeNumber;
        }

        public decimal Sum(Fractions a, Fractions b)
        {
            return a.CreativeNumber() + b.CreativeNumber();
        }

        public decimal Substraction(Fractions a, Fractions b)
        {
            return a.CreativeNumber() - b.CreativeNumber();
        }

        public decimal Multiplication(Fractions a, Fractions b)
        {
            return a.CreativeNumber() * b.CreativeNumber();
        }

        public decimal Division(Fractions a, Fractions b)
        {
            return a.CreativeNumber() / b.CreativeNumber();
        }

        public decimal HighNumber(Fractions a, Fractions b)
        {
            return Math.Max(a.CreativeNumber(), b.CreativeNumber());
        }

        public override string ToString()
        {
            return $" FirstNumber: {_numberLong}\n SecondNumber: {_numberInteger}\n Union {CreativeNumber()}\n ";
        }
    }
}