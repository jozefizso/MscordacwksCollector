using System;
using System.IO;

namespace MscordacwksCollector
{
    class DirectoryResolver
    {
        public static DirectoryInfo Expand(string relativeOrEnvironmentDirectory)
        {
            relativeOrEnvironmentDirectory = ReplaceEnvironmentVariables(relativeOrEnvironmentDirectory);
            try
            {
                var destinationDir = new DirectoryInfo(relativeOrEnvironmentDirectory);
                return destinationDir;
            }
            catch (Exception)
            {
                return new DirectoryInfo("");
            }            
        }

        private static string ReplaceEnvironmentVariables(string directoryName)
        {
            return Environment.ExpandEnvironmentVariables(directoryName);
        }
    }
}
