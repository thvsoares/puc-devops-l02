using System;

namespace Lista2DevOps
{
    public class RomanConverter
    {
        public string Convert(int decimalNumber)
        {
            if (decimalNumber == 1)
                return "I";

            throw new InvalidCastException();
        }
    }
}
