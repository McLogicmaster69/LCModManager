using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCModManager.IO
{
    public static class FileManager
    {
        public const string DATA_PATH = "Data";
        public const string DLL_PATH = "dlls";
        public const string PACKS_PATH = "packs";

        public static string FULL_DLL_PATH { get { return $"{DATA_PATH}/{DLL_PATH}"; } }
        public static string FULL_PACKS_PATH { get { return $"{DATA_PATH}/{PACKS_PATH}"; } }

        public static void InitDirectories()
        {
            if (!Directory.Exists(DATA_PATH))
                Directory.CreateDirectory(DATA_PATH);
            if (!Directory.Exists(FULL_DLL_PATH))
                Directory.CreateDirectory(FULL_DLL_PATH);
            if (!Directory.Exists(FULL_PACKS_PATH))
                Directory.CreateDirectory(FULL_PACKS_PATH);
        }
    }
}
