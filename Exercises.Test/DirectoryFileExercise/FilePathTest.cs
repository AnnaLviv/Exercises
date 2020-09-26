using Exercises.DirectoryFileExercise;
using NUnit.Framework;

namespace Exercises.Test.DirectoryFileExercise
{
    [TestFixture]
    //todo: consider making tests platform-independent
    public class FilePathTest
    {
        //This test is meant only for a proof of concept that refactored fucntionality works as original.
        //It is meant to be deleted once we delete original implementation
        [TestCase(null)]
        [TestCase(@"")]
        [TestCase(@"\mydir\")]
        [TestCase(@"C:\mydir\myfile.ext")]
        // 2 test below are different in refactored code than in original code
        // These tests pointed out bug in orginal implementation
        // If file is given without directory, directory should have no value, and file name should be returned correctly
        //[TestCase(@"myfile.ext")]
        //[TestCase(@"\myfile.ext")]
        [TestCase(@"myfile.ext\")]
        [TestCase(@"\mydir\myfile.ext")]
        [TestCase(@"D:\mydir\new folder\myfile.ext")]
        public void AssertOriginalAndRefactored(string path)
        {
            OriginalImplementation.SplitDirectoryFile(path, out var originalResultDirectory, out var originalResultFile);

            var filePathHandler = new FilePathHandler(path);
            var refactoredResultDirectory = filePathHandler.GetDirectory();
            var refactoredResultFile = filePathHandler.GetFile();

            //here we assert original and refactored outputs
            Assert.AreEqual(originalResultDirectory, refactoredResultDirectory);
            Assert.AreEqual(originalResultFile, refactoredResultFile);
        }


        [TestCase(null, null, null)]
        [TestCase(@"", @"", null)]
        [TestCase(@"\mydir\", @"\mydir", null)]
        [TestCase(@"C:\mydir\myfile.ext", @"C:\mydir", @"myfile.ext")]
        [TestCase(@"myfile.ext", @"", @"myfile.ext")]
        [TestCase(@"\myfile.ext", @"\", @"myfile.ext")]
        [TestCase(@"myfile.ext\", @"myfile.ext", null)]
        [TestCase(@"\mydir\myfile.ext", @"\mydir", @"myfile.ext")]
        [TestCase(@"D:\mydir\new folder\myfile.ext", @"D:\mydir\new folder", @"myfile.ext")]
        public void FilePathHandlerTest(string path,  string expectedDirectory, string expectedFile)
        {
            var filePathHandler = new FilePathHandler(path);
            var refactoredResultDirectory = filePathHandler.GetDirectory();
            var refactoredResultFile = filePathHandler.GetFile();

            Assert.AreEqual(expectedDirectory, refactoredResultDirectory);
            Assert.AreEqual(expectedFile, refactoredResultFile);
        }

    }
}
