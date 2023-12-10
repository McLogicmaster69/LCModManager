using LCModManager.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCModManager.Mods
{
    [System.Serializable]
    public class ModCollection
    {
        public ModDLLInformation[] DLLs;

        public ModCollection(ModDLLInformation[] dlls)
        {
            DLLs = dlls;
        }

        public ModCollection(DirectoryInfo dir)
        {
            List<ModDLLInformation> dlls = new List<ModDLLInformation>();
            HandleFolder(dir, dlls, "");
            DLLs = dlls.ToArray();
        }

        private void HandleFolder(DirectoryInfo dir, List<ModDLLInformation> dlls, string directory)
        {
            foreach(DirectoryInfo info in dir.GetDirectories())
            {
                HandleFolder(info, dlls, $"{directory}{info.Name}/");
            }
            foreach (FileInfo file in dir.GetFiles())
            {
                FileStream readStream = file.OpenRead();
                List<byte> bytes = new List<byte>();
                while (true)
                {
                    int nextByte = readStream.ReadByte();
                    if (nextByte == -1)
                        break;
                    bytes.Add((byte)nextByte);
                }
                readStream.Close();
                dlls.Add(new ModDLLInformation(bytes.ToArray(), file.Name, directory));
            }
        }
    }
}
