using Exercises.StackExercise;
using NUnit.Framework;
using System;

namespace Exercises.Test.StackExercise
{
    [TestFixture]
    public class StackTest
    {

        Stack<int> s;

        [SetUp]
        public void SetUp()
        {
            s = new Stack<int>(5);
        }

        [Test]
        public void Invalid_Creation()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Stack<string>(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Stack<double>(-1));
        }

        [Test]
        public void Creation()
        {
            Assert.AreEqual(0, s.Size);
        }

        [Test]
        public void Push_Pop()
        {
            s.Push(1);
            s.Push(1);
            s.Push(3);

            var value = s.Pop();
            Assert.AreEqual(3, value);
            Assert.AreEqual(2, s.Size);
        }

        [Test]
        public void Too_Much_Pop()
        {
            s.Push(1);
            s.Push(1);

            s.Pop();
            s.Pop();

            Assert.AreEqual(0, s.Size);

            Assert.Throws<StackExpenditureProhibitedException>(() => s.Pop());
        }

        [Test]
        public void Too_Much_Push()
        {
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);

            Assert.AreEqual(5, s.Size);

            Assert.Throws<StackExceededSizeException>(() => s.Push(4));
        }

        [Test]
        public void Peek_Exception()
        {
            Assert.AreEqual(0, s.Size);
            Assert.Throws<StackExpenditureProhibitedException>(() => s.Peek());
        }

        [Test]
        public void Peek_Element()
        {
            s.Push(1);
            s.Push(2);

            Assert.AreEqual(2, s.Size);

            int value = s.Peek();
            Assert.AreEqual(2, value);
            Assert.AreEqual(2, s.Size);
        }

    }
}
