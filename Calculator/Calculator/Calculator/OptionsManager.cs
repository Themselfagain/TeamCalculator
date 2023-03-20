using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
  public static  class OptionsManager
    {
        public static string[] OptionsList = {
            "ex - Exit",
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Devide",
            "sabs - SubtractAbs",
            "dr - DevideReminder",
            "pow - Power",
            "log - Logarithm",
            "min - Minimum",
            "max - Maximum",
            "avg - Average",
            "sqrt - SumSquareRoots",
            "sq - SumSquares"
            };

        public static string Add(double a, double b)
        {
            return $"{a} + {b} = {a + b}";
        }
        public static string SubtractAbs(double a, double b)
        {
            return $"|{a} - {b}| = {Math.Abs(a - b)}";
        }
        public static string Multiply(double a,double b)
        {
            return $"{a} * {b} = {a * b}";
        }
        public static string Subtract(double a, double b)
        { return $"{a} - {b} = {a - b}"; }
        public static string Devide(double a, double b)
        {
            if (b==0)
            {
                throw new InvalidOperationException ( $"Is not devisible by zero" );
            }
            else
            return $"{a} / {b} = {a / b}"; 
            }
        public static string DevideReminder(double a, double b)
        { return $"{a} : {b} = {a % b}"; }


        public static string Minimum(double a,double b)
        {
            return $"Min({a},{b})={Math.Min(a, b)}";
        }

        public static string Maximum(double a, double b)
        {
            return $"Max({a},{b})={Math.Max(a, b)}";
        }
    }
}
