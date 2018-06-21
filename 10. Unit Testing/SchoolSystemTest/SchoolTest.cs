using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitTestingHomework;
using System.Collections.Generic;

namespace SchoolSystemTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void MakeNewStudent()
        {
            Student kolio = new Student("kolio");
        }

        [TestMethod]
        public void MakeNewCourse()
        {
            Course foreighLanguage = new Course();
        }

        [TestMethod]
        public void MakeNewCourseWithStudents()
        {

            List<Student> groupA = new List<Student>();

            for (int i = 1; i < 11; i++)
            {
                groupA.Add(new Student("player " + i));
            }

            Course foreighLanguage = new Course(groupA);

        }


        [TestMethod]
        public void MakeGroupOfStudents()
        {
            List<Student> groupA = new List<Student>();

            for (int i = 1; i < 11; i++)
            {
                groupA.Add(new Student("player " + i));
            }
        }

        [TestMethod]
        public void MakeStudentsForOneFullCourse()
        {
            List<Student> groupA = new List<Student>();

            for (int i = 1; i < 30; i++)
            {
                groupA.Add(new Student("player " + i));
            }

            Course sport = new Course(groupA);
        }

        [TestMethod]
        public void AddStudentToCourseWithEmptySpace()
        {
            List<Student> groupA = new List<Student>();

            for (int i = 0; i < 15; i++)
            {
                groupA.Add(new Student("player " + i));
            }

            Course music = new Course(groupA);
            Student nekaf = new Student("nekaf");
            music.AddMe(nekaf);
            Assert.AreEqual(16, music.Counter());
        }

        [TestMethod]
        public void AddAndRemoveStudentFromCourse()
        {
            List<Student> groupA = new List<Student>();

            for (int i = 0; i < 15; i++)
            {
                groupA.Add(new Student("player " + i));
            }

            Course music = new Course(groupA);
            Student nekaf = new Student("nekaf");
            music.AddMe(nekaf);
            Assert.AreEqual(16, music.Counter());
            music.RemoveMe(nekaf);
            Assert.AreEqual(15, music.Counter());
        }



        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MaximumStudentsInSchool()
        {
            List<Student> groupA = new List<Student>();

            for (int i = 0; i < 89999; i++)
            {
                groupA.Add(new Student("player " + i));
            }

            Student nekaf = new Student("nekaf");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void MaximumStudentsInOneCourse()
        {
            List<Student> groupA = new List<Student>();

            for (int i = 0; i < 31; i++)
            {
                groupA.Add(new Student("player " + i));
            }

            Course history = new Course(groupA);
        }

        //Give exception, becuase above in test method we make enough students to reach maximum!
        [TestMethod]
        public void CreatSchool()
        {
            List<Student> groupA = new List<Student>();
            List<Student> groupB = new List<Student>();
            List<Student> groupC = new List<Student>();

            for (int i = 0; i < 25; i++)
            {
                groupA.Add(new Student("player " + i));
            }

            for (int j = 0; j < 25; j++)
            {
                groupB.Add(new Student("playerB " + j));
            }

            for (int q = 0; q < 25; q++)
            {
                groupC.Add(new Student("playerC " + q));
            }

            School UncleMagic = new School("Uncle Magic", "Magic Land", groupA, groupB, groupC);
        }

    }
}
