namespace OptionalHomeWork.Task2
{
    internal class Money
    {
        private long _numberLong;
        private byte _numberByte;
        private decimal _numberDecimal;
        public decimal Value;

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
        public Money(decimal numberDecimal)
        {
            _numberDecimal = numberDecimal;
        }

        public decimal CreativeNumber()
        {
            string union = (_numberLong + "," + _numberByte);
            decimal creativeNumber = Convert.ToDecimal(union);
            return creativeNumber;
        }

        public static Money operator +(Money money1, Money money2)
        {
            return new Money { Value = money1.Value + money2.Value };
        }
        public static bool operator >(Money money1, Money money2)
        {
            return money1.Value > money2.Value;
        }
        public static bool operator <(Money money1, Money money2)
        {
            return money1.Value < money2.Value;
        }

        public void Print()
        {
            Console.WriteLine( $" FirstNumber: {_numberLong}\n SecondNumber: {_numberByte}\n Union {CreativeNumber()}\n");
        }

        public override string ToString()
        {
            return $"Sum{Sum}"
        }



    }
}