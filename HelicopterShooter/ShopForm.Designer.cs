using System;
namespace HelicopterShooter
{
    partial class ShopForm
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
            this.PicBackGroundSkinsMenu = new System.Windows.Forms.PictureBox();
            this.PicHeroSkinsMenu = new System.Windows.Forms.PictureBox();
            this.BackGroundSkinsButton = new System.Windows.Forms.Button();
            this.HeroSkinsButton = new System.Windows.Forms.Button();
            this.CloseShopButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBackGroundSkinsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHeroSkinsMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBackGroundSkinsMenu
            // 
            this.PicBackGroundSkinsMenu.BackgroundImage = global::HelicopterShooter.Properties.Resources.BackGroundMain;
            this.PicBackGroundSkinsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBackGroundSkinsMenu.Location = new System.Drawing.Point(1060, 244);
            this.PicBackGroundSkinsMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PicBackGroundSkinsMenu.Name = "PicBackGroundSkinsMenu";
            this.PicBackGroundSkinsMenu.Size = new System.Drawing.Size(500, 500);
            this.PicBackGroundSkinsMenu.TabIndex = 8;
            this.PicBackGroundSkinsMenu.TabStop = false;
            // 
            // PicHeroSkinsMenu
            // 
            this.PicHeroSkinsMenu.BackgroundImage = global::HelicopterShooter.Properties.Resources.OIP__1_;
            this.PicHeroSkinsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicHeroSkinsMenu.Location = new System.Drawing.Point(360, 244);
            this.PicHeroSkinsMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PicHeroSkinsMenu.Name = "PicHeroSkinsMenu";
            this.PicHeroSkinsMenu.Size = new System.Drawing.Size(500, 500);
            this.PicHeroSkinsMenu.TabIndex = 7;
            this.PicHeroSkinsMenu.TabStop = false;
            // 
            // BackGroundSkinsButton
            // 
            this.BackGroundSkinsButton.BackgroundImage = global::HelicopterShooter.Properties.Resources.BackGroundSkinsButton;
            this.BackGroundSkinsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackGroundSkinsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackGroundSkinsButton.FlatAppearance.BorderSize = 0;
            this.BackGroundSkinsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BackGroundSkinsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BackGroundSkinsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackGroundSkinsButton.Location = new System.Drawing.Point(1110, 778);
            this.BackGroundSkinsButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackGroundSkinsButton.Name = "BackGroundSkinsButton";
            this.BackGroundSkinsButton.Size = new System.Drawing.Size(400, 150);
            this.BackGroundSkinsButton.TabIndex = 2;
            this.BackGroundSkinsButton.UseVisualStyleBackColor = true;
            this.BackGroundSkinsButton.Click += new System.EventHandler(this.BackGroundSkinsButton_Click);
            // 
            // HeroSkinsButton
            // 
            this.HeroSkinsButton.BackgroundImage = global::HelicopterShooter.Properties.Resources.HeroSkinsButton;
            this.HeroSkinsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroSkinsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeroSkinsButton.FlatAppearance.BorderSize = 0;
            this.HeroSkinsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HeroSkinsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HeroSkinsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeroSkinsButton.Location = new System.Drawing.Point(410, 778);
            this.HeroSkinsButton.Margin = new System.Windows.Forms.Padding(2);
            this.HeroSkinsButton.Name = "HeroSkinsButton";
            this.HeroSkinsButton.Size = new System.Drawing.Size(400, 150);
            this.HeroSkinsButton.TabIndex = 1;
            this.HeroSkinsButton.UseVisualStyleBackColor = true;
            this.HeroSkinsButton.Click += new System.EventHandler(this.HeroSkinsButton_Click);
            // 
            // CloseShopButton
            // 
            this.CloseShopButton.BackgroundImage = global::HelicopterShooter.Properties.Resources.ButtonBack2;
            this.CloseShopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseShopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseShopButton.FlatAppearance.BorderSize = 0;
            this.CloseShopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CloseShopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CloseShopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseShopButton.Location = new System.Drawing.Point(42, 33);
            this.CloseShopButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseShopButton.Name = "CloseShopButton";
            this.CloseShopButton.Size = new System.Drawing.Size(240, 80);
            this.CloseShopButton.TabIndex = 0;
            this.CloseShopButton.UseVisualStyleBackColor = true;
            this.CloseShopButton.Click += new System.EventHandler(this.CloseShopButton_click);
            // 
            // ShopForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.PicBackGroundSkinsMenu);
            this.Controls.Add(this.PicHeroSkinsMenu);
            this.Controls.Add(this.BackGroundSkinsButton);
            this.Controls.Add(this.HeroSkinsButton);
            this.Controls.Add(this.CloseShopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            ((System.ComponentModel.ISupportInitialize)(this.PicBackGroundSkinsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicHeroSkinsMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseShopButton;
        private System.Windows.Forms.Button HeroSkinsButton;
        private System.Windows.Forms.Button BackGroundSkinsButton;
        private System.Windows.Forms.PictureBox PicHeroSkinsMenu;
        private System.Windows.Forms.PictureBox PicBackGroundSkinsMenu;
    }
}