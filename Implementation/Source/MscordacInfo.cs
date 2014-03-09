using System.IO;

namespace MscordacwksCollector
{
    class MscordacInfo
    {
        internal MscordacInfo(FileInfo source, string architecture, string version)
        {
            Source = source;
            Architecture = architecture;
            Version = version;
        }

        internal FileInfo Source;
        private readonly string Architecture;
        private string Version;
        
        internal string DebuggerName
        {
            get
            {
                string basename = Source.Name.Substring(0, Source.Name.Length - 4);
                return string.Format("{2}_{0}_{0}_{1}.dll", Architecture, Version, basename);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", DebuggerName, Source.FullName);
        }
    }
}
