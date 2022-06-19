namespace OptionalHomeWork.Task2
{
    internal class Money
    {
        public long _numberLong { get; set; }
        public byte _numberByte { get; set; }

        public Money()
        {
            _numberLong = 0;
            _numberByte = 0;
        }

        public Money(long numberLong, byte numberByte)
        {
            _numberLong = numberLong;
            _numberByte = numberByte;
        }

        public decimal CreativeNumber()
        {
            string union = (_numberLong + "," + _numberByte);
            decimal creativeNumber = Convert.ToDecimal(union);
            return creativeNumber;
        }

        public decimal Sum(Money a, Money b)
        {
            return a.CreativeNumber() + b.CreativeNumber();
        }

        public decimal Substraction(Money a, Money b)
        {
            return a.CreativeNumber() - b.CreativeNumber();
        }

        public decimal Multiplication(Money a, Money b)
        {
            return a.CreativeNumber() * b.CreativeNumber();
        }

        public decimal Multiplication(Money a, Money b, decimal fractional)
        {
            return a.CreativeNumber() * b.CreativeNumber() * fractional;
        }

        public decimal Division(Money a, Money b)
        {
            return a.CreativeNumber() / b.CreativeNumber();
        }

        public decimal Division(Money a, Money b, decimal fractional)
        {
            return a.CreativeNumber() / b.CreativeNumber() * fractional;
        }

        public decimal HighNumber(Money a, Money b)
        {
            return Math.Max(a.CreativeNumber(), b.CreativeNumber());
        }

        public void Print()
        {
            Console.WriteLine($" FirstNumber: {_numberLong}\n SecondNumber: {_numberByte}\n Union {CreativeNumber()}\n");
        }
    }
}