namespace MscordacwksCollector
{
    public class StructureResolver
    {
        public string Expand(string structure, IMscordacInfo mscordacInfo)
        {
            string result = structure.Replace(@"$§", "$§§");
            result = result.Replace("$$", "$§");
            result = result.Replace("$A", mscordacInfo.Architecture);
            result = result.Replace("$T", mscordacInfo.Type);
            result = result.Replace("$V", mscordacInfo.Version.ToString(4));
            string numeric = mscordacInfo.Architecture == "AMD64" ? "64" : "32";
            result = result.Replace("$N", numeric);
            result = result.Replace("$§", "$");
            return result;
        }
    }
}