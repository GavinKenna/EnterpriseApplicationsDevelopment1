using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7;

namespace TestLab7
{
    [TestClass]
    public class UnitTest1
    {
        static Class sclass;

        public void Set() //Init's sclass
        {
            sclass = new Class(23, "Tim");
            sclass.AddStudent(0, "Gavin", GENDER.MALE);
            sclass.AddStudent(1, "Sean", GENDER.MALE);
            sclass.AddStudent(2, "Rob", GENDER.MALE);
            sclass.AddStudent(3, "Dave", GENDER.MALE);
        }

        [TestMethod]
        public void TestMethod1() //Should pass, adding safe data
        {
            sclass = new Class(23, "Tim");
            sclass.AddStudent(0, "Gavin", GENDER.MALE);
            sclass.AddStudent(1, "Sean", GENDER.MALE);
            sclass.AddStudent(2, "Rob", GENDER.MALE);
            sclass.AddStudent(3, "Dave", GENDER.MALE);
            sclass.AddStudent(4, "Paul", GENDER.MALE);
            sclass.AddStudent(5, "Jamie", GENDER.MALE);
            sclass.AddStudent(6, "Emma", GENDER.FEMALE);
            sclass.AddStudent(7, "Hazel", GENDER.FEMALE);
            sclass.AddStudent(8, "Emily", GENDER.FEMALE);
        }

        [TestMethod]
        public void AddIllegalData()
        {
            Set();
            sclass.AddStudent(0, "Gavin's Evil Twin", GENDER.FEMALE);
        }

        [TestMethod]
        public void ReturnInvalidStudent()
        {
            Set();
            Student s = sclass[19];
        }
    }
}
