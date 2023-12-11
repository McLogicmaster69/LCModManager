using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCModManager.Lists
{
    public partial class SteamFolderInput : Form
    {
        public SteamFolderInput()
        {
            InitializeComponent();
        }

        private void OpenFolderDialouge_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderDialog = new OpenFileDialog();
            DialogResult result = folderDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                FolderTxt.Text = folderDialog.FileName;
            }
        }
    }
}
