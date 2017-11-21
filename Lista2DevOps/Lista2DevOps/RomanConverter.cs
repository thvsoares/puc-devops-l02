using System;
using System.Text;

namespace Lista2DevOps
{
    public class RomanConverter
    {
        public string Convert(int decimalNumber)
        {
            if (decimalNumber < 1 || decimalNumber > 10000)
                throw new InvalidCastException();

            var result = new StringBuilder();
            while (decimalNumber > 0)
            {
                if (decimalNumber > 3)
                {
                    throw new NotImplementedException();
                }
                else // > 3
                {
                    while (decimalNumber-- > 0) { result.Append("I"); }
                }
            }
            return result.ToString();
        }
    }
}
