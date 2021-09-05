using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            Fraction f1 = new Fraction(3,4);
            Fraction f2 = new Fraction(2,3);
            f1.Print();
            
            Fraction f3 = f1 * a;
            f3.Print();
            
            Fraction f4 = f1 +f2;
            f4.Print();

            Fraction f5 = f1 - f2;
            f5.Print();

            if (f1 == f2) 
            {
                WriteLine("Дроби равны");
            }
            else
            {
                WriteLine("Дроби не равны");
            }

            if (f1 > f2)
            {
                WriteLine($"Дробь {f1._chisl}/{f1._znam} больше дроби {f2._chisl}/{f2._znam}");
            }
            else
            {
                WriteLine($"Дробь {f1._chisl}/{f1._znam} меньше дроби {f2._chisl}/{f2._znam}");
            }

        }
    }
}
