using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Linear : IRoot
    {
        private double x;
        public double A;
        public double B;

        public Linear(double a, double b)
        {
            A = a;
            B = b;
        }

        public string getSquare()
        {
            return $"Linear: {-B / A}";
        }
    }
}