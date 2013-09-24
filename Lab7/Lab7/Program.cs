using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Gavin", GENDER.MALE);

            Class sclass = new Class(2, "Tom");
            sclass.AddStudent(2, "Bob", GENDER.MALE);
            sclass.AddStudent(3, "Lucy", GENDER.FEMALE);
            sclass.AddStudent(4, "Sarah", GENDER.FEMALE);
            sclass.AddStudent(5, "Richard", GENDER.MALE);
            sclass.AddStudent(2, "Mia", GENDER.FEMALE);

            sclass[3] = s;
            sclass[4] = s;

            Console.WriteLine(sclass[3].ToString());
            Console.WriteLine(sclass[2].ToString());

            Console.Read();
        }
    }
}
