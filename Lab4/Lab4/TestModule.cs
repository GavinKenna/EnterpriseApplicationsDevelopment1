using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class TestModule
    {
        public static void Run()
        {
            ModuleCAResults mcar = new ModuleCAResults("EAD1", "Gavin Kenna", 12);
            mcar["CA1"] = "B+";
            mcar["CA2"] = "A-";
            mcar["CA4"] = "C";
            mcar["CA3"] = "A+";

            Console.WriteLine("CA3 is :: "+mcar["CA3"]);


            Console.WriteLine(mcar.ToString());

            Console.Read();
        }
    }
}
