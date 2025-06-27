using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Triangle<T>
    {
        private T a, b, c;

        public T A
        {
            get { return a; }
            set { a = value; }
        }

        public T B
        {
            get { return b; }
            set { b = value; }
        }

        public T C
        {
            get { return c; }
            set { c = value; }
        }

        public Triangle(T a, T b, T c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Стороны: A={A}, B={B}, C={C}");
            Console.WriteLine($"Площадь: {GetArea():F2}");
        }

        public double GetArea()
        {
            double x = Convert.ToDouble(A);
            double y = Convert.ToDouble(B);
            double z = Convert.ToDouble(C);

            double s = (x + y + z) / 2;
            return Math.Sqrt(s * (s - x) * (s - y) * (s - z));
        }
    }
}
/*
 * int Name
 * {
 * get {return name;}
 * set {name = value;}
 * }
 */
