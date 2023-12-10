using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCModManager.Mods
{
    [System.Serializable]
    public class ModDLLInformation
    {
        public readonly byte[] Bytes;
        public readonly string FileName;
        public readonly string Directory;

        public ModDLLInformation(byte[] bytes, string fileName, string directory)
        {
            Bytes = bytes;
            FileName = fileName;
            Directory = directory;
        }
    }
}
