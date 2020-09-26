using Exercises.DirectoryFileExercise;
using NUnit.Framework;

namespace Exercises.Test.DirectoryFileExercise
{
    [TestFixture]
    //todo: consider making tests platform-independent
    public class OriginalImplementationPathHelperTest
    {
        [TestCase('\\', true)] // '\\' equals '\' in C#
        [TestCase('/', false)]
        public void IsDirectorySeparatorTest(char pathCharacter, bool expectedResult )
        {
            var result = OriginalImplementationPathHelper.IsDirectorySeparator(pathCharacter);
            Assert.AreEqual(expectedResult, result);
        }


        [TestCase(@"C:\mydir\myfile.ext", false)]
        [TestCase(@"\mydir\", true)]
        public void EndsInDirectorySeparatorTest(string path, bool expectedResult)
        {
            var result = OriginalImplementationPathHelper.EndsInDirectorySeparator(path);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(@"C:\mydir\myfile.ext", 3)]
        [TestCase(@"myfile.ext", 0)]   
        [TestCase(@"\mydir\", 1)]
        [TestCase(@"", 0)]
        public void GetRootLengthTest(string path, int expectedResult)
        {
            var result = OriginalImplementationPathHelper.GetRootLength(path);
            Assert.AreEqual(expectedResult, result);
        }
   }
}
