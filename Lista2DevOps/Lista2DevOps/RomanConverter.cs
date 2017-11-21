using System;

namespace Lista2DevOps
{
    public class RomanConverter
    {
        public string Convert(int decimalNumber)
        {
            switch (decimalNumber)
            {
                case 01: return "I";
                case 02: return "II";
                case 03: return "III";
                case 04: return "IV";
                case 05: return "V";
                case 06: return "VI";
                case 07: return "VII";
                case 08: return "VIII";
                case 09: return "IX";
                case 10: return "X";
            }
            throw new InvalidCastException();
        }
    }
}
