using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class TestCalculator
    {
        public void Run()
        {
            double x, y;

            Console.WriteLine("Please enter a number to divide ::");
            x = GetDoubleFromUser();

            Console.WriteLine("Please enter a number to divide into "+x+" ::");
            y = GetDoubleFromUser();

            Console.WriteLine(Calculator.DivideTwoNumbers(x,y));

            Console.Read();
        }

        private double GetDoubleFromUser()
        {
            double temp;
            try
            {
                temp = Double.Parse(Console.ReadLine());
                return temp;
            }
            catch (FormatException fe)
            {
                SetConsoleColourToRed();
                Console.WriteLine("ERROR, FORMAT EXCEPTION :: \n" + fe.Message);
                Console.WriteLine("\nPlease try entering a number again...\n");
                
                ResetConsoleColour();
                return GetDoubleFromUser();
            }
            catch (OverflowException oe)
            {
                SetConsoleColourToRed();
                Console.WriteLine("ERROR, OVERFLOW EXCEPTION :: \n" + oe.Message);
                Console.WriteLine("\nPlease try entering a number again...\n");
                ResetConsoleColour();
                return GetDoubleFromUser();
            }
            catch (Exception e)
            {
                SetConsoleColourToRed();
                Console.WriteLine("ERROR, UNKNOWN EXCEPTION :: \n" + e.Message);
                ResetConsoleColour();
                Console.WriteLine("\nPlease try entering a number again...\n");
                return GetDoubleFromUser();
            }
            finally
            {
                ResetConsoleColour();
            }
        }

        private void ResetConsoleColour()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void SetConsoleColourToRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
