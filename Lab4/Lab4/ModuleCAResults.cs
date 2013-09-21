using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    //Part 2

    class ModuleCAResults
    {
        public string ModuleName { get; set; }
        public string StudentName { get; set; }
        public int Credits { get; set; }

        public SortedDictionary<string, string> CAs { get; set; }

        public ModuleCAResults(string name, string studentName, int credits)
        {
            this.ModuleName = name;
            this.StudentName = studentName;
            this.Credits = credits;

            this.CAs = new SortedDictionary<string, string>();
        }

        public string this[string ca]
        {
            get
            {
                try
                {
                    if (this.CAs[ca] == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        return this.CAs[ca];
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    return "";
                }
            }
            set
            {
                this.CAs[ca] = value;
            }
        }

        public override string ToString()
        {
            string information = "";
            information += "MODULE NAME :: " + this.ModuleName;
            information += "\nSTUDENT NAME :: " + this.StudentName;
            information += "\nCREDITS :: " + this.Credits;

            information += "\nCA INFORMATION :: ";

            foreach (var entry in CAs)
            {
                information += "\n\t" + entry.Key + " :: " + entry.Value;
            }

            return information;
        }
    }
}
