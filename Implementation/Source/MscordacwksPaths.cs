using System;
using System.IO;

namespace MscordacwksCollector
{
    static class MscordacwksPaths
    {
        private static readonly string WindowsDirectory = Environment.ExpandEnvironmentVariables("%WINDIR%");

        internal static DirectoryInfo NetFramework64
        {
            get
            {
                return new DirectoryInfo(
                    Path.Combine(WindowsDirectory,
                                 @"Microsoft.NET\Framework64\"));
            }
        }

        internal static DirectoryInfo NetFramework
        {
            get
            {
                return new DirectoryInfo(
                    Path.Combine(WindowsDirectory,
                                 @"Microsoft.NET\Framework\"));
            }
        }

        internal static DirectoryInfo WinSxs
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
