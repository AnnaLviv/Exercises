using Exercises.MoveExercise;
using NUnit.Framework;
using System.ComponentModel;

namespace Exercises.Test.MoveExercise
{
    [TestFixture]
    public class MoveTest
    {
        [TestCase("Up", "Basic Up Move")]
        [TestCase("Down", "Basic Down Move")]
        [TestCase("Left", "Basic Left Move")]
        [TestCase("Right", "Basic Right Move")]
        public void BasicMoveNameTest(string moveKey, string expectedMoveName)
        {
            var moveHandler = new MoveHandler();
            var moveName = moveHandler.ExecuteMove(moveKey);
            Assert.AreEqual(expectedMoveName, moveName);
        }

        [Test]
        public void ComboMoveNameTest()
        {
            var moveHandler = new MoveHandler();
            var moveName = moveHandler.ExecuteMove("Combo");
            Assert.AreEqual("Up Up Down Down Combo Move", moveName);
        }

        [Test]
        public void MoveUnsupportedTest()
        {
            var moveHandler = new MoveHandler();
            Assert.Throws<InvalidEnumArgumentException>(()=> moveHandler.ExecuteMove("Unsupported"));
        }        

    }
}
