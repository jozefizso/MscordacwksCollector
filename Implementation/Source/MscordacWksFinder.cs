using System;
using System.Collections.Generic;
using System.IO;

namespace MscordacwksCollector
{
    class MscordacWksFinder
    {
        private readonly Action<MscordacInfo> _progressUpdateHandler;

        public MscordacWksFinder(Action<MscordacInfo> onItemFound)
        {
            _progressUpdateHandler = onItemFound;
        }

        internal IList<MscordacInfo> Find(IList<DirectoryInfo> directories)
        {
            IList<MscordacInfo> files = new List<MscordacInfo>();
            foreach (var directory in directories)
            {
                if (directory.Exists)
                {
                    AddAllFiles(directory, "mscordacwks.dll", files);
                    AddAllFiles(directory, "sos.dll", files);
                }
            }

            return files;
        }

        private void AddAllFiles(DirectoryInfo directory, string mscordacwksDLL, IList<MscordacInfo> files)
        {
            foreach (var subdir in directory.GetDirectories("*.*", SearchOption.TopDirectoryOnly))
            {
                AddAllFiles(subdir, mscordacwksDLL, files);
            }
            var dlls = directory.GetFiles(mscordacwksDLL, SearchOption.TopDirectoryOnly);
            foreach (var dll in dlls)
            {
                var item = new MscordacInfo(dll, DllHelper.Architecture(dll), DllHelper.Version(dll));
                files.Add(item);
                _progressUpdateHandler(item);
            }
        }
    }
}
