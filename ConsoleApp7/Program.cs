using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var triangle1 = new Triangle<int>(3, 4, 5);
                triangle1.PrintInfo();

                var triangle2 = new Triangle<uint>(5, 12, 13);
                triangle2.PrintInfo();

                var triangle3 = new Triangle<double>(7.5, 8.2, 9.3);
                triangle3.PrintInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
