﻿using NUnit.Framework;


namespace AD
{
    [TestFixture]
    public partial class MyStackCircularTests
    {
        [Test]
        public void MyStack_1_Constructor_1_IsEmptyReturnsTrue()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            bool expected = true;

            // Act
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_1_IsEmptyReturnsFalse()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            bool expected = false;

            // Act
            stack.Push("a");
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_2_TopIsOkAfter1Push()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            string expected = "a";

            // Act
            stack.Push("a");
            string actual = stack.Top();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_3_TopIsOkAfter3Push()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            string expected = "c";

            // Act
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            string actual = stack.Top();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_4_PopIsOkAfter1Push()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            string expected = "a";

            // Act
            stack.Push("a");
            string actual = stack.Pop();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_5_PopIsOkAfter3Push()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            string expected = "c";

            // Act
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            string actual = stack.Pop();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_2_Push_6_TwoTimesPopIsOkAfter3Push()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            string expected = "b";

            // Act
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            stack.Pop();
            string actual = stack.Pop();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_3_Top_1_ThrowsExceptionOnEmptyStack()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();

            // Act & Assert
            Assert.Throws(typeof(MyStackEmptyException), () => stack.Top());
        }

        [Test]
        public void MyStack_3_Top_2_IsEmptyReturnsFalseAfterTopOnOneElement()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            bool expected = false;

            // Act
            stack.Push("a");
            stack.Top();
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MyStack_4_Pop_1_ThrowsExceptionOnEmptyList()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();

            // Act & Assert
            Assert.Throws(typeof(MyStackEmptyException), () => stack.Pop());
        }

        [Test]
        public void MyStack_4_Pop_2_IsEmptyReturnsTrueAfterTopOnOneElement()
        {
            // Arrange
            IMyStack<string> stack = DSBuilder.CreateMyStackCircularStringEmpty5();
            bool expected = true;

            // Act
            stack.Push("a");
            stack.Pop();
            bool actual = stack.IsEmpty();

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}