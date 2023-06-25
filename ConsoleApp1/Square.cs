using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Square : IRoot
    {
        public double a;
        public double b;
        public double c;
        private double d;
        public double x;
        public double y;

        public double C 
        { 
            get { return c; }
            set { c = value; }
        }

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public Square(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string getSquare()
        {
            d = Math.Pow(B, 2) - 4 * A * C;
            if (d < 0) return "No solution?";
            else if (d == 0) return "x1 = 0, x2 = 0";
            else return $"x1 = {-B - Math.Sqrt(d) / 2 * A}, x2 = {-B + Math.Sqrt(d) / 2 * A}";
        }
    }
}