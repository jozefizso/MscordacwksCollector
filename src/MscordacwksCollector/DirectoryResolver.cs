using System;
using System.IO;

namespace MscordacwksCollector
{
    static class DirectoryResolver
    {
        public static DirectoryInfo Expand(string relativeOrEnvironmentDirectory)
        {
            relativeOrEnvironmentDirectory = Environment.ExpandEnvironmentVariables(relativeOrEnvironmentDirectory);
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
    }
}
