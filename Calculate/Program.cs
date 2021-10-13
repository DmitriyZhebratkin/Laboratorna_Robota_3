using System;
using System.Globalization;

namespace Calculate
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();
                string r = s; // это импровизация от меня, чтобы дальше можно было проверить строку на наличие символа:)
                string[] array2 = s.Split(new char[] { '-', '+', '*' });
                var deletedsym = new string[] { " ", "+", "-", "*" };
                foreach (var c in deletedsym) { s = s.Replace(c, string.Empty); }

                NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
                {
                    NumberDecimalSeparator = ".",
                };
                double a1 = double.Parse(array2[0], numberFormatInfo);
                double a2 = double.Parse(array2[1], numberFormatInfo);
                

                if (r.Contains('+'))
                {

                    Calculate1 plus = new Calculate1();
                    plus.Plus1(a1, a2);

                }
                else if (r.Contains('-'))
                {
                    Calculate1 minus = new Calculate1();
                    minus.Minus1(a1, a2);

                }
                else if (r.Contains('*'))
                {
                    Calculate1 umnozhenie = new Calculate1();
                    umnozhenie.Umnozhenie1(a1, a2);

                }
                else
                {
                    Console.Write("Такого знаку немає!");
                }

            }

        }
    }
    class Calculate1
    {
        public void Plus1(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public void Minus1(double a1, double a2)
        {
            Console.WriteLine(a1 - a2);
        }
        public void Umnozhenie1(double a1, double a2)
        {
            Console.WriteLine(a1 * a2);

        }
    }
}

