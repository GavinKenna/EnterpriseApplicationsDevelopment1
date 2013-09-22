using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new Money(14.50, CURRENCY.EURO);
            Money m2 = new Money(29.13, CURRENCY.USDOLLARS);
            Money m3 = new Money(2.33, CURRENCY.YEN);

            Console.WriteLine("Euro :: " + m1.Amount + " to USD is :: " + m1.Convert(CURRENCY.USDOLLARS));
            Console.WriteLine("Euro :: " + m1.Amount + " to YEN is :: " + m1.Convert(CURRENCY.YEN));
            Console.WriteLine();

            Console.WriteLine("Yen :: " + m3.Amount + " to USD is :: " + m3.Convert(CURRENCY.USDOLLARS));
            Console.WriteLine("Yen :: " + m3.Amount + " to EURO is :: " + m3.Convert(CURRENCY.EURO));
            Console.WriteLine();

            Console.WriteLine("USD :: " + m2.Amount + " to EURO is :: " + m2.Convert(CURRENCY.EURO));
            Console.WriteLine("USD :: " + m2.Amount + " to YEN is :: " + m2.Convert(CURRENCY.YEN));
            Console.WriteLine();

            //Adding two Money objects together

            Money a = new Money(13.99, CURRENCY.EURO);
            Money b = new Money(99.34, CURRENCY.USDOLLARS);

            Console.WriteLine("Euro :: " + a.Amount + " + USD :: " + b.Amount + " = Euro :: " + (a + b).Amount);

            Console.Read();
        }
    }
}
