using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Calculator
    {
        //Decided on returning a String as
        //it could then return an error message, because if it
        //were a double, it would still need to return a number
        //if an error was thrown.
        public static string DivideTwoNumbers(double x, double y)
        {
            try
            {
                if (y == 0)
                {
                    throw new ArgumentException();
                }else{
                    return x + " divided by " + y + " is :: "+ x/y;
                }
            }
            catch(ArgumentException e){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR, CANNOT BE DIVIDED BY 0!");
                return "Error";
            }
        }
    }
}
