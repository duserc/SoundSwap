using System.Reflection;

namespace SetFileLibrary
{
    public class SetFileClass
    {
        public static string setFile()
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string directoryPath = Path.Combine(path, "config");
            string settingsFile = Path.Combine(directoryPath, "Settings.json");

            return settingsFile;
        }
    }
}