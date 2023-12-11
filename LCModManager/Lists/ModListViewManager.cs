using LCModManager.Mods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCModManager.Lists
{
    public class ModListViewManager : ListViewManager
    {
        public ModListViewManager(ListView list, int overflowColumn, ListColumnDetails[] columns) : base(list, overflowColumn, columns)
        {
        }

        public void AddMod(Mod mod) => AddItem(new string[2] { mod.ModName, "" });
    }
}
