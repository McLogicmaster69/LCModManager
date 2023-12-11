using LCModManager.IO;
using LCModManager.Lists;
using LCModManager.Mods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCModManager
{
    public partial class MainFrm : Form
    {
        private ModListViewManager _listViewManager;
        private FormWindowState _lastWindowState;

        public MainFrm()
        {
            InitializeComponent();

            _listViewManager = new ModListViewManager(ModList, 0, 
                new ListColumnDetails[] { 
                    new ListColumnDetails("name", 10, HorizontalAlignment.Left), 
                    new ListColumnDetails("status", 1, HorizontalAlignment.Center) 
                });
            _listViewManager.UpdateWidth(ModList.Width);
            _lastWindowState = WindowState;

            FileManager.InitDirectories();
            FileManager.OpenAllModCollections();

            RefreshList();

            if (!File.Exists("steampath.txt"))
            {
                SteamFolderInput sfi = new SteamFolderInput();
                sfi.Show();
            }
        }

        private void MainFrm_Resize(object sender, EventArgs e)
        {
            if (_listViewManager == null)
                return;

            if (WindowState != _lastWindowState)
            {
                _lastWindowState = WindowState;
                _listViewManager.UpdateWidth(ModList.Width);
            }
        }

        private void MainFrm_ResizeEnd(object sender, EventArgs e)
        {
            _listViewManager.UpdateWidth(ModList.Width);
        }

        private void CreateCollectionBtn_Click(object sender, EventArgs e)
        {
            FileManager.ConvertDLLsToCollection();
            CollectionStatusText.Text = "Successfully created collection";
        }

        private void RefreshList()
        {
            ModList.Items.Clear();
            List<Mod> mods = FileManager.GetMods();
            foreach(Mod mod in mods)
            {
                _listViewManager.AddMod(mod);
            }
        }
    }
}
