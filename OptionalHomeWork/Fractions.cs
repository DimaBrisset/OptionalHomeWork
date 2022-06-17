using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalHomeWork.Task1
{
    internal class Fractions
    {
        private long _numberLong;
        private int _numberInteger;

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
            decimal IngeBorgaDapkunayte = Convert.ToDecimal(union);
            return IngeBorgaDapkunayte;
        }

        public override string ToString()
        {
            return $" FirstNumber: {_numberLong}\n SecondNumber: {_numberInteger}\n Union {CreativeNumber()}\n ";
        }
    }
}