using System;
using System.Text;

namespace Lista2DevOps
{
    public class RomanConverter
    {
        public string Convert(int decimalNumber)
        {
            var numero = decimalNumber.ToString();
            int tamanho = numero.Length;
            int quadroValor = 0;
            StringBuilder retorno = new StringBuilder();
            while (quadroValor != tamanho)
            {
                switch (tamanho - quadroValor)
                {
                    case 5:
                        return "X*";//representa 10000 x com traço em cima
                    case 4:
                        retorno.Append(VerificaMilhar(System.Convert.ToInt16(numero.Substring(quadroValor, 1))));
                        break;
                    case 3:
                        retorno.Append(VerificaCentena(System.Convert.ToInt16(numero.Substring(quadroValor, 1))));
                        break;
                    case 2:
                        retorno.Append(VerificaDezena(System.Convert.ToInt16(numero.Substring(quadroValor, 1))));
                        break;
                    case 1:
                        retorno.Append(VerificaUnidade(System.Convert.ToInt16(numero.Substring(quadroValor, 1))));
                        break;
                    default:
                        break;
                }
                quadroValor++;
            }

            return retorno.ToString();
        }

        private string VerificaUnidade(short unidade)
        {
            switch (unidade)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                default:
                    return string.Empty;
            }
        }

        private string VerificaDezena(short dezena)
        {
            switch (dezena)
            {
                case 1:
                    return "X";
                case 2:
                    return "XX";
                case 3:
                    return "XXX";
                case 4:
                    return "XL";
                case 5:
                    return "L";
                case 6:
                    return "LX";
                case 7:
                    return "LXX";
                case 8:
                    return "LXXX";
                case 9:
                    return "XC";
                default:
                    return string.Empty;
            }

        }

        private string VerificaCentena(short centena)
        {
            switch (centena)
            {
                case 1:
                    return "C";
                case 2:
                    return "CC";
                case 3:
                    return "CCC";
                case 4:
                    return "CD";
                case 5:
                    return "D";
                case 6:
                    return "DC";
                case 7:
                    return "DCC";
                case 8:
                    return "DCCC";
                case 9:
                    return "CM";
                default:
                    return string.Empty;
            }

        }

        private string VerificaMilhar(short milhar)
        {
            switch (milhar)
            {
                case 1:
                    return "M";
                case 2:
                    return "MM";
                case 3:
                    return "MMM";
                case 4:
                    return "IV*"; //representa o traço em cima do valor;
                case 5:
                    return "V*";
                case 6:
                    return "VI*";
                case 7:
                    return "VII*";
                case 8:
                    return "VIII*";
                case 9:
                    return "IX*";
                default:
                    return string.Empty;
            }

        }
    }
}
