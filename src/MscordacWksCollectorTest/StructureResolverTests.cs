using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MscordacwksCollector;

namespace MscordacWksCollectorTest
{
    [TestClass]
    public class StructureResolverTests
    {
        [TestMethod]
        public void A_returns_Architecture()
        {
            var structureResolver = new StructureResolver();
            var architecture = structureResolver.Expand("$A", new MscordacwksMock64());
            Assert.AreEqual("AMD64",architecture);

            architecture = structureResolver.Expand("$A", new MscordacwksMock32());
            Assert.AreEqual("x86", architecture);
        }

        [TestMethod]
        public void V_returns_4_digit_Version()
        {
            var structureResolver = new StructureResolver();
            var version = structureResolver.Expand("$V", new MscordacwksMock64());
            Assert.AreEqual("1.2.3.4", version);
        }

        [TestMethod]
        public void N_returns_numeric_Architecture()
        {
            var structureResolver = new StructureResolver();
            var numeric = structureResolver.Expand("$N", new MscordacwksMock64());
            Assert.AreEqual("64", numeric);

            numeric = structureResolver.Expand("$N", new MscordacwksMock32());
            Assert.AreEqual("32", numeric);
        }

        [TestMethod]
        public void T_returns_Type()
        {
            var structureResolver = new StructureResolver();
            var type = structureResolver.Expand("$T", new MscordacwksMock64());
            Assert.AreEqual("SOS", type);
        }

        [TestMethod]
        public void Dollar_is_escape_character()
        {
            var structureResolver = new StructureResolver();
            var dollar = structureResolver.Expand("$$", new MscordacwksMock64());
            Assert.AreEqual("$", dollar);

            dollar = structureResolver.Expand("$$A", new MscordacwksMock64());
            Assert.AreEqual("$A", dollar);
        }

        [TestMethod]
        public void Dollar_is_escape_character_internal_implementation()
        {
            var structureResolver = new StructureResolver();
            var paragraph = structureResolver.Expand("$§", new MscordacwksMock64());
            Assert.AreEqual("$§", paragraph);
        }

        [TestMethod]
        public void Unknown_remains_unchanged()
        {
            var structureResolver = new StructureResolver();
            var unknown = structureResolver.Expand("$X", new MscordacwksMock64());
            Assert.AreEqual("$X", unknown);
        }

        [TestMethod]
        public void Real_world_flat()
        {
            var structureResolver = new StructureResolver();
            var unknown = structureResolver.Expand("$T_$A_$A_$V.dll", new MscordacwksMock64());
            Assert.AreEqual("SOS_AMD64_AMD64_1.2.3.4.dll", unknown);
        }

        [TestMethod]
        public void Real_world_default()
        {
            var structureResolver = new StructureResolver();
            var unknown = structureResolver.Expand(@"$A\$V\$T.dll", new MscordacwksMock64());
            Assert.AreEqual(@"AMD64\1.2.3.4\SOS.dll", unknown);
        }

        [TestMethod]
        public void Real_world_numeric_subdirs()
        {
            var structureResolver = new StructureResolver();
            var unknown = structureResolver.Expand(@"$N bit\$V\$T.dll", new MscordacwksMock64());
            Assert.AreEqual(@"64 bit\1.2.3.4\SOS.dll", unknown);
        }

        class MscordacwksMock64 : IMscordacInfo
        {
            public MscordacwksMock64()
            {
                Source=new FileInfo(@"C:\sos.dll");
                Architecture = "AMD64";
                Version = new Version(1,2,3,4);
                Type = "SOS";
            }
            public FileInfo Source { get; private set; }
            public string Architecture { get; protected set; }
            public Version Version { get; private set; }
            public string Type { get; private set; }

            public string DebuggerName
            {
                get { return string.Format("{2}_{0}_{0}_{1}.dll", Architecture, Version.ToString(4), Type); }
            }
        }

        class MscordacwksMock32 : MscordacwksMock64
        {
            public MscordacwksMock32()
            {
                Architecture = "x86";
            }
        }
    }
}
