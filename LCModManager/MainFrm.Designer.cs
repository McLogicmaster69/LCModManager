
namespace LCModManager
{
    partial class MainFrm
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
            this.LaunchVanillaButton = new System.Windows.Forms.Button();
            this.LaunchModdedBtn = new System.Windows.Forms.Button();
            this.ModList = new System.Windows.Forms.ListView();
            this.CreateCollectionBtn = new System.Windows.Forms.Button();
            this.CollectionStatusText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LaunchVanillaButton
            // 
            this.LaunchVanillaButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LaunchVanillaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchVanillaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LaunchVanillaButton.Location = new System.Drawing.Point(12, 12);
            this.LaunchVanillaButton.Name = "LaunchVanillaButton";
            this.LaunchVanillaButton.Size = new System.Drawing.Size(163, 30);
            this.LaunchVanillaButton.TabIndex = 1;
            this.LaunchVanillaButton.Text = "LAUNCH VANILLA";
            this.LaunchVanillaButton.UseVisualStyleBackColor = false;
            // 
            // LaunchModdedBtn
            // 
            this.LaunchModdedBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LaunchModdedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchModdedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.LaunchModdedBtn.Location = new System.Drawing.Point(12, 48);
            this.LaunchModdedBtn.Name = "LaunchModdedBtn";
            this.LaunchModdedBtn.Size = new System.Drawing.Size(163, 30);
            this.LaunchModdedBtn.TabIndex = 2;
            this.LaunchModdedBtn.Text = "LAUNCH MODDED";
            this.LaunchModdedBtn.UseVisualStyleBackColor = false;
            // 
            // ModList
            // 
            this.ModList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModList.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ModList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ModList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.ModList.HideSelection = false;
            this.ModList.Location = new System.Drawing.Point(181, 12);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(314, 434);
            this.ModList.TabIndex = 3;
            this.ModList.UseCompatibleStateImageBehavior = false;
            // 
            // CreateCollectionBtn
            // 
            this.CreateCollectionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateCollectionBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CreateCollectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCollectionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.CreateCollectionBtn.Location = new System.Drawing.Point(12, 416);
            this.CreateCollectionBtn.Name = "CreateCollectionBtn";
            this.CreateCollectionBtn.Size = new System.Drawing.Size(163, 30);
            this.CreateCollectionBtn.TabIndex = 4;
            this.CreateCollectionBtn.Text = "CREATE COLLECTION";
            this.CreateCollectionBtn.UseVisualStyleBackColor = false;
            this.CreateCollectionBtn.Click += new System.EventHandler(this.CreateCollectionBtn_Click);
            // 
            // CollectionStatusText
            // 
            this.CollectionStatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CollectionStatusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.CollectionStatusText.ForeColor = System.Drawing.Color.Lime;
            this.CollectionStatusText.Location = new System.Drawing.Point(12, 369);
            this.CollectionStatusText.Name = "CollectionStatusText";
            this.CollectionStatusText.Size = new System.Drawing.Size(163, 44);
            this.CollectionStatusText.TabIndex = 5;
            this.CollectionStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(507, 458);
            this.Controls.Add(this.CollectionStatusText);
            this.Controls.Add(this.CreateCollectionBtn);
            this.Controls.Add(this.ModList);
            this.Controls.Add(this.LaunchModdedBtn);
            this.Controls.Add(this.LaunchVanillaButton);
            this.MinimumSize = new System.Drawing.Size(523, 497);
            this.Name = "MainFrm";
            this.Text = "Lethal Company Mod Manager";
            this.ResizeEnd += new System.EventHandler(this.MainFrm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button LaunchVanillaButton;
        private System.Windows.Forms.Button LaunchModdedBtn;
        private System.Windows.Forms.ListView ModList;
        private System.Windows.Forms.Button CreateCollectionBtn;
        private System.Windows.Forms.Label CollectionStatusText;
    }
}

