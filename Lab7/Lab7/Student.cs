using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public enum GENDER { MALE, FEMALE };

    public class Student
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public GENDER Gender { get; private set; }

        public Student(int id, string name, GENDER gender)
        {
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return "STUDENT ID :: " + this.ID + "\n\tSTUDENT NAME :: " + this.Name + "\n\tSTUDENT GENDER :: " + this.Gender + "\n";
        }
    }
}
