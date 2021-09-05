using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Fraction
{
    public class Fraction
    {
        public int _chisl { get; set; }
        public int _znam { get; set; }

        public Fraction(int _chisl, int _znam)
        {
            this._chisl = _chisl;
            this._znam = _znam;

        }
        public static bool operator true(Fraction f)
        {
            return f._chisl < f._znam ? true : false;
        }
        public static bool operator false(Fraction f)
        {
            return f._chisl >= f._znam ? true : false;
        }
        public static Fraction operator *(Fraction f, int a)
        {

            return new Fraction(f._chisl * a, f._znam);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {

            Fraction f = new Fraction(f1._chisl * f2._chisl, f1._znam * f2._znam);
            if (f)
            {
                WriteLine("Дробь правильная");
                return f;
                
            }
            else
            {
                WriteLine("Дробь неправильная");
                return f;
                
            }
        }
        public static Fraction operator/(Fraction f1, Fraction f2)
        {

            Fraction f = new Fraction(f1._chisl * f2._znam, f1._znam * f2._chisl);
            if (f)
            {
                WriteLine("Дробь правильная");
                return f;

            }
            else
            {
                WriteLine("Дробь неправильная");
                return f;

            }
        }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {

            Fraction f = new Fraction(f1._chisl * f2._znam+f2._chisl*f1._znam, f1._znam * f2._znam);
            if (f)
            {
                WriteLine("Дробь правильная");
                return f;

            }
            else
            {
                WriteLine("Дробь неправильная");
                return f;

            }
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {

            Fraction f = new Fraction(f1._chisl * f2._znam - f2._chisl * f1._znam, f1._znam * f2._znam);
            if (f)
            {
                WriteLine("Дробь правильная");
                return f;

            }
            else
            {
                WriteLine("Дробь неправильная");
                return f;

            }
        }

        //переопределение метода Equals
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Fraction f = obj as Fraction; // возвращает null если объект нельзя привести к типу Fraction
            if (f as Fraction == null)
                return false;

            return f._chisl == this._chisl && f._znam == this._znam;
            
        }
        // необходимо также переопределить метод 
        // GetHashCode
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Fraction f1, Fraction f2)
        {
           
            return f1.Equals(f2);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            
            return !(f1==f2);
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {

            return (f1._chisl*f2._znam > f2._chisl*f1._znam);
        }
        public static bool operator<(Fraction f1, Fraction f2)
        {

            return (f1._chisl * f2._znam < f2._chisl * f1._znam);
        }   
       



        //public void Reduction()
        //{
        //    int a = Math.Abs(_chisl);
        //    int b = Math.Abs(_znam);
        //    int c = 1;

        //    while (c > 0)
        //    {
        //        c = b % a;
        //        a = b;
        //        b = c;
        //    }
        //    int nok = a * _chisl * _znam;
        //    // Находим НОД
        //    if (nok != 1)
        //    {
        //        _chisl = _chisl / nok;
        //        _znam = _znam / nok;
        //    }

        //}
        public void Print()
        {
            WriteLine($"{_chisl}/{_znam}");
           
        }
    }
}
