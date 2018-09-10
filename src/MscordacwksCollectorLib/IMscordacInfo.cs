using System;
using System.IO;

namespace MscordacwksCollector
{
    public interface IMscordacInfo
    {
        FileInfo Source { get; }
        string Architecture { get; }
        Version Version { get; }
        string Type { get; }

        /// <summary>
        /// Name of the DLL as required by the debugger (WinDbg) in order to find and load the data access components correctly.
        /// </summary>
        string DebuggerName { get; }
    }
}