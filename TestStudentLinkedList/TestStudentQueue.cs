using System;
using Xunit;
using ChessCRM.Models;

namespace UnitTesting
{
    public class TestStudentQueue
    {
        [Fact]
        public void TestisEmptyTrue()
        {
            //Arrange
            StudentQueue sQueue = new StudentQueue();
            bool actual;
            //Act
            actual = sQueue.isEmpty();
            //Assert
            Assert.True(actual);
        }

        [Fact]
        public void TestisEmptyFalse()
        {
            //Arrange
            StudentQueue sQueue = new StudentQueue();
            Student s = new Student();
            bool actual;
            //Act
            sQueue.Enqueue(s);
            actual = sQueue.isEmpty();
            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void TestSize()
        {
            //Arrange
            StudentQueue sQueue = new StudentQueue();
            Student s = new Student();
            int actual, expected;
            expected = 2;
            //Act
            sQueue.Enqueue(s);
            sQueue.Enqueue(s);
            sQueue.Enqueue(s);
            sQueue.Dequeue();
            sQueue.Dequeue();
            sQueue.Enqueue(s);

            actual = sQueue.Size();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPeek()
        {
            //Arrange
            StudentQueue sQueue = new StudentQueue();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            s1.Lname = "alpha"; s1.Fname = "john";
            s2.Lname = "beta"; s2.Fname = "joe";
            s3.Lname = "charlie"; s3.Fname = "jane";
            string actual, expected;
            expected = s1.Print();
            //Act
            sQueue.Enqueue(s1);
            sQueue.Enqueue(s2);
            sQueue.Enqueue(s3);
            actual = sQueue.Peek().Print();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPrint()
        {
            //Arrange
            StudentQueue sQueue = new StudentQueue();
            Student s1 = new Student();
            Student s2 = new Student();
            Student s3 = new Student();
            s1.Lname = "alpha"; s1.Fname = "john";
            s2.Lname = "beta"; s2.Fname = "joe";
            s3.Lname = "charlie"; s3.Fname = "jane";
            string actual, expected;
            expected = s1.Print() + s2.Print() + s3.Print();
            //Act
            sQueue.Enqueue(s1);
            sQueue.Enqueue(s2);
            sQueue.Enqueue(s3);
            actual = sQueue.Print();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEnqueue()
        {
            //Arrange
            StudentQueue sQueue = new StudentQueue();
            Student s = new Student();
            int actual, expected;
            expected = 3;
            //Act
            sQueue.Enqueue(s);
            sQueue.Enqueue(s);
            sQueue.Enqueue(s);
            actual = sQueue.Size();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDequeue()
        {
            //Arrange
            StudentQueue sQueue = new StudentQueue();
            Student s = new Student();
            int actual, expected;
            expected = 1;
            //Act
            sQueue.Enqueue(s);
            sQueue.Enqueue(s);
            sQueue.Enqueue(s);
            sQueue.Dequeue();
            sQueue.Dequeue();
            actual = sQueue.Size();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
