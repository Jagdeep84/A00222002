using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    class calculator
    {
        public static double DoOperation(double N1, double N2, string op)
        {
            double result = double.NaN;
            switch (op)
            {
                case "+":
                    result = N1 + N2;
                    break;
                case "-":
                    result = N1 - N2;
                    break;
                case "*":
                    result = N1 * N2;
                    break;
                case "/":

                    if (N2 != 0)
                    {
                        result = N1 / N2;
                    }
                    break;

                default:
                    break;
            }
            return result;
        }
    }
}
