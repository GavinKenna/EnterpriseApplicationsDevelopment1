using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab6
{
    public delegate void EventHandler();
    class TestCountdownTimer
    {
        static  CountdownTimer ct;
        public static void Run()
        {
            ct = new CountdownTimer(1000.12);
            ct.Finished += new EventHandler(FinishedCountdown);

            Console.WriteLine("STARTING...");
            ct.StartCountdown();

            Console.WriteLine("DONE. ENTER FOR LAMBA EXPRESSION..");
            Console.Read();

            ct = new CountdownTimer(1000.12);
            ct.Finished += new EventHandler(delegate() { Console.Beep(); });
            ct.StartCountdown();

            Console.WriteLine("DONE.");
            Console.Read();
        }

        static void FinishedCountdown()
        {
            Console.Beep();
        }
    }
}
