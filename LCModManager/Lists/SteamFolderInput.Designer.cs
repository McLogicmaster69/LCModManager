
namespace LCModManager.Lists
{
    partial class SteamFolderInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CollectionStatusText = new System.Windows.Forms.Label();
            this.FolderTxt = new System.Windows.Forms.TextBox();
            this.OpenFolderDialouge = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CollectionStatusText
            // 
            this.CollectionStatusText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectionStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CollectionStatusText.ForeColor = System.Drawing.Color.Lime;
            this.CollectionStatusText.Location = new System.Drawing.Point(12, 15);
            this.CollectionStatusText.Name = "CollectionStatusText";
            this.CollectionStatusText.Size = new System.Drawing.Size(383, 44);
            this.CollectionStatusText.TabIndex = 6;
            this.CollectionStatusText.Text = "Please input path to lethal company exe";
            this.CollectionStatusText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FolderTxt
            // 
            this.FolderTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.FolderTxt.Location = new System.Drawing.Point(12, 62);
            this.FolderTxt.Name = "FolderTxt";
            this.FolderTxt.Size = new System.Drawing.Size(352, 25);
            this.FolderTxt.TabIndex = 7;
            // 
            // OpenFolderDialouge
            // 
            this.OpenFolderDialouge.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.OpenFolderDialouge.FlatAppearance.BorderSize = 0;
            this.OpenFolderDialouge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenFolderDialouge.Location = new System.Drawing.Point(370, 62);
            this.OpenFolderDialouge.Name = "OpenFolderDialouge";
            this.OpenFolderDialouge.Size = new System.Drawing.Size(25, 25);
            this.OpenFolderDialouge.TabIndex = 8;
            this.OpenFolderDialouge.Text = "...";
            this.OpenFolderDialouge.UseVisualStyleBackColor = false;
            this.OpenFolderDialouge.Click += new System.EventHandler(this.OpenFolderDialouge_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(383, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "CONFIRM";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // SteamFolderInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(407, 174);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OpenFolderDialouge);
            this.Controls.Add(this.FolderTxt);
            this.Controls.Add(this.CollectionStatusText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SteamFolderInput";
            this.Text = "SteamFolderInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CollectionStatusText;
        private System.Windows.Forms.TextBox FolderTxt;
        private System.Windows.Forms.Button OpenFolderDialouge;
        private System.Windows.Forms.Button button2;
    }
}