using System;
using System.Diagnostics;
using System.IO;

namespace MscordacwksCollector
{
    class DllHelper
    {

        internal static string Version(FileInfo dll)
        {
            var file = FileVersionInfo.GetVersionInfo(dll.FullName);
            return file.ProductVersion;
        }

        private static MachineType GetDllMachineType(string dllPath)
        {
            //see http://www.microsoft.com/whdc/system/platform/firmware/PECOFF.mspx
            //offset to PE header is always at 0x3C
            //PE header starts with "PE\0\0" =  0x50 0x45 0x00 0x00
            //followed by 2-byte machine type field (see document above for enum)
            FileStream fs = new FileStream(dllPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            fs.Seek(0x3c, SeekOrigin.Begin);
            Int32 peOffset = br.ReadInt32();
            fs.Seek(peOffset, SeekOrigin.Begin);
            UInt32 peHead = br.ReadUInt32();
            if (peHead != 0x00004550) // "PE\0\0", little-endian
            {
                throw new Exception("Can't find PE header");
            }
            var machineType = (MachineType)br.ReadUInt16();
            br.Close();
            fs.Close();
            return machineType;
        }

        private enum MachineType : ushort
        {
            IMAGE_FILE_MACHINE_AMD64 = 0x8664,
            IMAGE_FILE_MACHINE_I386 = 0x14c,
            IMAGE_FILE_MACHINE_IA64 = 0x200,
        }

        internal static string Architecture(FileInfo dll)
        {
            switch (GetDllMachineType(dll.FullName))
            {
                case MachineType.IMAGE_FILE_MACHINE_AMD64:
                    return "AMD64";
                case MachineType.IMAGE_FILE_MACHINE_I386:
                    return "x86";
                case MachineType.IMAGE_FILE_MACHINE_IA64:
                    return "IA64";
                default:
                    throw new InvalidOperationException("Architecture not supported");
            }
        }
    }
}
