using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCModManager.Mods
{
    public class Mod
    {
        public readonly string ModPath;
        public readonly string ModName;

        public Mod(string path, string name)
        {
            ModPath = path;
            ModName = name;
        }
    }
}
