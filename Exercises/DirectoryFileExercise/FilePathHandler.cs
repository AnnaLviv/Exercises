using System.IO;

namespace Exercises.DirectoryFileExercise
{
    public class FilePathHandler
    {
        public string FilePath { get; }

        public FilePathHandler(string filePath)
        {
            FilePath = filePath;
        }

        public string GetDirectory()
        {
            //To align with original implementation, we return directory value for null filepath and for empty filepath as in original.
            //Todo: consider removing these if statements.
            if (FilePath == null)
                return null;
            if (string.IsNullOrEmpty(FilePath))
                return string.Empty;

            return Path.GetDirectoryName(FilePath);
        }

        public string GetFile()
        {
            var fileName = Path.GetFileName(FilePath);

            //To align with original, we return null in case filepath is an emty string.
            //Todo: consider removing this if statement.
            if (string.IsNullOrEmpty(fileName))
            {
                return null;
            }             

            return fileName;
        }
    }
}
