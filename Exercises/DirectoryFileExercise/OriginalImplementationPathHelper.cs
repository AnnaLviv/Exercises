using System.IO;

namespace Exercises.DirectoryFileExercise
{
    public static class OriginalImplementationPathHelper
    {
        public static int GetRootLength(string path)
        {
            var rootPath = Path.GetPathRoot(path);
            if (rootPath != null)
                return rootPath.Length;
            else
                return 0;
        }

        public static bool EndsInDirectorySeparator(string path)
        {
            return path.EndsWith(Path.DirectorySeparatorChar.ToString());
        }

        public static bool IsDirectorySeparator(char v)
        {
            return v.Equals(Path.DirectorySeparatorChar);
        }
    }
}
