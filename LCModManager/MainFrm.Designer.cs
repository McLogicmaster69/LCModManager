
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
            this.ModList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ModList.HideSelection = false;
            this.ModList.Location = new System.Drawing.Point(181, 12);
            this.ModList.Name = "ModList";
            this.ModList.Size = new System.Drawing.Size(314, 434);
            this.ModList.TabIndex = 3;
            this.ModList.UseCompatibleStateImageBehavior = false;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(507, 458);
            this.Controls.Add(this.ModList);
            this.Controls.Add(this.LaunchModdedBtn);
            this.Controls.Add(this.LaunchVanillaButton);
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
    }
}

