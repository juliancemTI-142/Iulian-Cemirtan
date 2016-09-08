using System;

namespace Code_Module
{
    public class Operators
    {
        public static string Add(double n1, double n2)
        {
            return (n1 + n2).ToString();
        }

        public static string Sub(double n1, double n2)
        {
            return (n1 - n2).ToString();
        }

        public static string Mul(double n1, double n2)
        {
            return (n1 * n2).ToString();
        }

        public static string Div(double n1, double n2)
        {
            return (n1 / n2).ToString();
        }

        public static string Root(double n)
        {
            return string.Format("{0,6}", Math.Sqrt(n));
        }

        public static string Power(double n1, double n2)
        {
            return string.Format("{0,6}", Math.Pow(n1, n2));
        }

        public static string Inverse(double n)
        {
            return string.Format("{0}", -n);
        }
    }
}
