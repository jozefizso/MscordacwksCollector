using System;
using System.IO;

namespace MscordacwksCollector
{
    public static class MscordacwksPaths
    {
        private static readonly string WindowsDirectory = Environment.ExpandEnvironmentVariables("%WINDIR%");

        public static DirectoryInfo NetFramework64
        {
            get
            {
                return new DirectoryInfo(
                    Path.Combine(WindowsDirectory,
                                 @"Microsoft.NET\Framework64\"));
            }
        }

        public static DirectoryInfo NetFramework
        {
            get
            {
                return new DirectoryInfo(
                    Path.Combine(WindowsDirectory,
                                 @"Microsoft.NET\Framework\"));
            }
        }

        public static DirectoryInfo WinSxs
        {
            get
            {
                return new DirectoryInfo(
                    Path.Combine(WindowsDirectory,
                    "winsxs"));
            }
        }
    }
}
