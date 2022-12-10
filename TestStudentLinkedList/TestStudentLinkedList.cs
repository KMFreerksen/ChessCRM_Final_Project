using System;
using Xunit;
using ChessCRM.Models;

namespace UnitTesting
{
    public class TestStudentLinkedList
    {
        [Fact]
        public void TestisEmptyTrue()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            bool actual;
            //Act
            actual = sList.isEmpty();
            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestisEmptyFalse()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s = new Student();
            bool actual;
            //Act
            sList.AddLast(s);
            actual = sList.isEmpty();
            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void TestisFullTrue()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s = new Student();
            int max = 500;
            bool actual;
            //Act
            while (sList.Size < max)
            {
                sList.AddLast(s);
            }
            actual = sList.isFull();
            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestisFullFalse()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s = new Student();
            bool actual;
            //Act
            sList.AddLast(s);
            actual = sList.isFull();
            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Testsize()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s = new Student();
            int actual, expected;
            expected = 3;
            //Act
            sList.AddLast(s);
            sList.AddLast(s);
            sList.AddLast(s);
            actual = sList.Size;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAdd()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            s1.Lname = "alpha"; s1.Fname = "john";
            s2.Lname = "beta"; s2.Fname = "joe";
            s3.Lname = "charlie"; s3.Fname = "jane";
            s4.Lname = "delta"; s4.Fname = "jill";
            Student[] actual, expected;
            expected = new Student[500]; expected[0] = s3; expected[1] = s4; expected[2] = s1; expected[3] = s2;
            //Act
            sList.AddLast(s1);
            sList.AddLast(s2);
            sList.AddFirst(s3);
            sList.AddAt(s4, 1);
            actual = sList.Students;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestRemove()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            s1.Lname = "alpha"; s1.Fname = "john";
            s2.Lname = "beta"; s2.Fname = "joe";
            s3.Lname = "charlie"; s3.Fname = "jane";
            s4.Lname = "delta"; s4.Fname = "jill";
            Student actual, expected, actual2, expected2;
            expected = s1; expected2 = s2;
            //Act
            sList.AddLast(s1);
            sList.AddLast(s2);
            sList.AddLast(s3);
            sList.AddLast(s4);
            sList.RemoveLast();
            sList.RemoveAt(2);
            actual = sList.Students[0]; actual2 = sList.Students[1];
            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void TestContains()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            s1.Lname = "alpha"; s1.Fname = "john";
            s2.Lname = "beta"; s2.Fname = "joe";
            s3.Lname = "charlie"; s3.Fname = "jane";
            s4.Lname = "delta"; s4.Fname = "jill";
            bool actual;
            //Act
            sList.AddLast(s1);
            sList.AddLast(s2);
            sList.AddLast(s3);
            sList.AddLast(s4);
            actual = sList.Contains(s2);
            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestFind()
        {
        //Arrange
        StudentLinkedList sList = new StudentLinkedList();
        Student s1 = new Student();
        Student s2 = new Student();
        Student s3 = new Student();
        Student s4 = new Student();
        s1.Lname = "alpha"; s1.Fname = "john";
        s2.Lname = "beta"; s2.Fname = "joe";
        s3.Lname = "charlie"; s3.Fname = "jane";
        s4.Lname = "delta"; s4.Fname = "jill";
        int actual, expected;
        expected = 1;
        //Act
        sList.AddLast(s1);
        sList.AddLast(s2);
        sList.AddLast(s3);
        sList.AddLast(s4);
        actual = sList.Find(s2);
        //Assert
        Assert.Equal(expected, actual);
    }
        
        [Fact]
        public void TestPrint()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            s1.Lname = "alpha"; s1.Fname = "john";
            s2.Lname = "beta"; s2.Fname = "joe";
            s3.Lname = "charlie"; s3.Fname = "jane";
            s4.Lname = "delta"; s4.Fname = "jill";
            string actual, expected;
            expected = "alpha, john\nbeta, joe\ncharlie, jane\ndelta, jill\n";
            //Act
            sList.AddLast(s1);
            sList.AddLast(s2);
            sList.AddLast(s3);
            sList.AddLast(s4);
            actual = sList.Print();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestAlphaSort()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            s1.Lname = "alpha"; s1.Fname = "john";
            s2.Lname = "beta"; s2.Fname = "joe";
            s3.Lname = "charlie"; s3.Fname = "jane";
            s4.Lname = "delta"; s4.Fname = "jill";
            string actual, expected;
            expected = "alpha, john\nbeta, joe\ncharlie, jane\ndelta, jill\n";
            //Act
            sList.AddLast(s1);
            sList.AddLast(s2);
            sList.AddFirst(s3);
            sList.AddAt(s4, 1);
            sList.AlphabetizeByLname();
            actual = sList.Print();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestGetCurrent()
        {
            //Arrange
            StudentLinkedList sList = new StudentLinkedList();
            StudentLinkedList activeList = new StudentLinkedList();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            Student s4 = new Student();
            s1.Lname = "alpha"; s1.Fname = "john"; s1.Active = true;
            s2.Lname = "beta"; s2.Fname = "joe"; s2.Active = false;
            s3.Lname = "charlie"; s3.Fname = "jane"; s3.Active = true;
            s4.Lname = "delta"; s4.Fname = "jill"; s4.Active = false;
            string actual, expected;
            expected = "alpha, john\ncharlie, jane\n";
            //Act
            sList.AddLast(s1);
            sList.AddLast(s2);
            sList.AddFirst(s3);
            sList.AddAt(s4, 1);
            sList.AlphabetizeByLname();
            activeList = sList.GetCurrent();
            actual = activeList.Print();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
