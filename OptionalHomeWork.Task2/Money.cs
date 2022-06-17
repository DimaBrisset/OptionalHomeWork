namespace OptionalHomeWork.Task2
{
    internal class Money
    {

        private long _numberLong;
        private byte _numberByte;

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

        public decimal CreativeCardBalance()
        {
            string union = (_numberLong + "," + _numberByte);
            decimal IngeBorgaDapkunayte = Convert.ToDecimal(union);
            return IngeBorgaDapkunayte;
        }

        public override string ToString()
        {
            return $" FirstNumber: {_numberLong}\n SecondNumber: {_numberByte}\n Union {CreativeCardBalance()}\n ";
        }

    }
}
