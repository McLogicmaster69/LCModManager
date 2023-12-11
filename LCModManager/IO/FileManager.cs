using LCModManager.Mods;
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
        public const string LOAD_PATH = "loads";
        public const string MOD_COLLECTION_EXTENSION = ".mc";
        public const string MOD_COLLECTION_DEFAULT_NAME = "collection";
        public const string STEAM_FOLDER_FILE = "steamfolder.txt";

        public static string FULL_DLL_PATH { get { return $"{DATA_PATH}/{DLL_PATH}"; } }
        public static string FULL_PACKS_PATH { get { return $"{DATA_PATH}/{PACKS_PATH}"; } }
        public static string FULL_LOAD_PATH { get { return $"{DATA_PATH}/{LOAD_PATH}"; } }

        public static void InitDirectories()
        {
            if (!Directory.Exists(DATA_PATH))
                Directory.CreateDirectory(DATA_PATH);
            if (!Directory.Exists(FULL_DLL_PATH))
                Directory.CreateDirectory(FULL_DLL_PATH);
            if (!Directory.Exists(FULL_PACKS_PATH))
                Directory.CreateDirectory(FULL_PACKS_PATH);
            if (!Directory.Exists(FULL_LOAD_PATH))
                Directory.CreateDirectory(FULL_LOAD_PATH);
        }

        public static void ConvertDLLsToCollection()
        {
            ModCollection collection = new ModCollection(new DirectoryInfo(FULL_DLL_PATH));
            SaveSystem.Save<ModCollection>(collection, $"{FULL_LOAD_PATH}/{MOD_COLLECTION_DEFAULT_NAME}{MOD_COLLECTION_EXTENSION}");
        }

        public static void OpenAllModCollections()
        {
            foreach (FileInfo file in new DirectoryInfo(FULL_LOAD_PATH).GetFiles($"*{MOD_COLLECTION_EXTENSION}"))
            {
                ModCollection collection = SaveSystem.Load<ModCollection>(file.FullName);

                foreach(ModDLLInformation dll in collection.DLLs)
                {
                    if (!Directory.Exists($"{FULL_DLL_PATH}/{dll.Directory}"))
                        Directory.CreateDirectory($"{FULL_DLL_PATH}/{dll.Directory}");
                    FileStream writer = new FileStream($"{FULL_DLL_PATH}/{dll.Directory}{dll.FileName}", FileMode.Create);
                    writer.Write(dll.Bytes, 0, dll.Bytes.Length);
                    writer.Close();
                }
                file.Delete();
            }
        }

        public static bool CheckForSteamFile() => File.Exists(STEAM_FOLDER_FILE);

        public static List<Mod> GetMods() 
        {
            List<Mod> output = new List<Mod>();
            GetAllModsInFolder(new DirectoryInfo(FULL_DLL_PATH), output, FULL_DLL_PATH + "/");
            return output;
        } 

        private static void GetAllModsInFolder(DirectoryInfo dir, List<Mod> mods, string directory)
        {
            foreach (DirectoryInfo info in dir.GetDirectories())
            {
                GetAllModsInFolder(info, mods, $"{directory}{info.Name}/");
            }
            foreach (FileInfo file in dir.GetFiles("*.dll"))
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
                mods.Add(new Mod(directory, file.Name.Substring(0, file.Name.Length - 4)));
            }
        }
    }
}
