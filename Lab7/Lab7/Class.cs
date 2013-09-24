using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Class
    {
        public int CRN { get; set; }
        public string Lecturer { get; set; }
        public ArrayList Students { get; set; }

        public Class(int crn, string lecturer)
        {
            this.CRN = crn;
            this.Lecturer = lecturer;
            Students = new ArrayList();
        }

        public void AddStudent(int id, string name, GENDER gender)
        {
            try
            {
                var query = from Student student in Students
                            where student.ID == id
                            select student; //Decided to use LINQ for searching the array list
                if (query.Count() > 0)
                {
                    throw new StudentIDExistsException();
                }
                else
                {
                    Students.Add(new Student(id, name, gender));
                }

            }
            catch (StudentIDExistsException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Student this[int i]
        {
            get
            {
                try
                {
                    return (Student)this.Students[i];
                }
                catch (IndexOutOfRangeException e1)
                {
                    Console.WriteLine(e1.Message);
                    return null;
                }
                catch (NullReferenceException e2)
                {
                    Console.WriteLine(e2.Message);
                    return null;
                }
                catch (Exception e3)
                {
                    Console.WriteLine(e3.Message);
                    return null;
                }
            }

            set
            {
                try
                {
                    if (IsStudentDataLegal(value))
                    {
                        (this.Students[i]) = value;
                    }
                    else
                    {
                        throw new Exception("Student data not legal.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               
                
            }

        }

        private bool IsStudentDataLegal(Student value)
        {
            var query = from Student student in Students
                        where student.ID == value.ID
                        select student; //Decided to use LINQ for searching the array list

            if (query.Count() > 0 || value.Name == null || value.Gender == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

    public class StudentIDExistsException : Exception
    {
        public StudentIDExistsException()
            : base("Student ID already exists")
        {
        }
    }

}
