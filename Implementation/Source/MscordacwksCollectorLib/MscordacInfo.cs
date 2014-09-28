using System;
using System.IO;

namespace MscordacwksCollector
{
    /// <summary>
    /// Data class containing information about Microsoft Data Access Components (Mscordacwks) DLL.
    /// </summary>
    public class MscordacInfo
    {
        internal MscordacInfo(FileInfo source, string architecture, Version version)
        {
            Source = source;
            Architecture = architecture;
            Version = version;
            Type = Source.Name.Substring(0, Source.Name.Length - 4);
        }

        public readonly FileInfo Source;
        public readonly string Architecture;
        public readonly Version Version;
        public readonly string Type;

        /// <summary>
        /// Name of the DLL as required by the debugger (WinDbg) in order to find and load the data access components correctly.
        /// </summary>
        public string DebuggerName
        {
            get
            {
                return string.Format("{2}_{0}_{0}_{1}.dll", Architecture, Version.ToString(4), Type   );
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", DebuggerName, Source.FullName);
        }
    }
}
