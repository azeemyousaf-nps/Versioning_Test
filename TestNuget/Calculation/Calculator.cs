using System;
using System.Collections.Generic;
using System.Text;

namespace TestNuget.Calculation
{
    public  class Calculator
    {
        public static double Add(double a, double b) { return a + b; }
        public static double Subtract(double a, double b) { return a - b; }
        public static double Multiply(double a, double b) { return a * b; }
        public static double Divide(double a, double b) { return a / b; }
        public static double Modular(int a, int mod) { return a % mod; }
    }
}
