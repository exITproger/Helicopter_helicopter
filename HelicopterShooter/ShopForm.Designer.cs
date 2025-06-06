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
            this.BackGroundSkinsButton = new System.Windows.Forms.Button();
            this.CloseShopButton = new System.Windows.Forms.Button();
            this.HeroSkinButton = new System.Windows.Forms.Button();
            this.HeroSkinsPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBackGroundSkinsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroSkinsPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBackGroundSkinsMenu
            // 
            this.PicBackGroundSkinsMenu.BackgroundImage = global::HelicopterShooter.Properties.Resources.BackGroundMain;
            this.PicBackGroundSkinsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBackGroundSkinsMenu.Location = new System.Drawing.Point(428, 207);
            this.PicBackGroundSkinsMenu.Margin = new System.Windows.Forms.Padding(2);
            this.PicBackGroundSkinsMenu.Name = "PicBackGroundSkinsMenu";
            this.PicBackGroundSkinsMenu.Size = new System.Drawing.Size(500, 500);
            this.PicBackGroundSkinsMenu.TabIndex = 8;
            this.PicBackGroundSkinsMenu.TabStop = false;
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
            this.BackGroundSkinsButton.Location = new System.Drawing.Point(478, 729);
            this.BackGroundSkinsButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackGroundSkinsButton.Name = "BackGroundSkinsButton";
            this.BackGroundSkinsButton.Size = new System.Drawing.Size(400, 150);
            this.BackGroundSkinsButton.TabIndex = 2;
            this.BackGroundSkinsButton.UseVisualStyleBackColor = true;
            this.BackGroundSkinsButton.Click += new System.EventHandler(this.BackGroundSkinsButton_Click);
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
            // HeroSkinButton
            // 
            this.HeroSkinButton.BackgroundImage = global::HelicopterShooter.Properties.Resources.HeroSkinsButton;
            this.HeroSkinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroSkinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HeroSkinButton.FlatAppearance.BorderSize = 0;
            this.HeroSkinButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.HeroSkinButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.HeroSkinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeroSkinButton.Location = new System.Drawing.Point(1118, 729);
            this.HeroSkinButton.Margin = new System.Windows.Forms.Padding(2);
            this.HeroSkinButton.Name = "HeroSkinButton";
            this.HeroSkinButton.Size = new System.Drawing.Size(400, 150);
            this.HeroSkinButton.TabIndex = 9;
            this.HeroSkinButton.UseVisualStyleBackColor = true;
            this.HeroSkinButton.Click += new System.EventHandler(this.HeroSkinButton_Click);
            // 
            // HeroSkinsPicture
            // 
            this.HeroSkinsPicture.BackColor = System.Drawing.Color.Transparent;
            this.HeroSkinsPicture.BackgroundImage = global::HelicopterShooter.Properties.Resources.picHeroSkinShop;
            this.HeroSkinsPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HeroSkinsPicture.Location = new System.Drawing.Point(1065, 207);
            this.HeroSkinsPicture.Margin = new System.Windows.Forms.Padding(2);
            this.HeroSkinsPicture.Name = "HeroSkinsPicture";
            this.HeroSkinsPicture.Size = new System.Drawing.Size(500, 500);
            this.HeroSkinsPicture.TabIndex = 10;
            this.HeroSkinsPicture.TabStop = false;
            // 
            // ShopForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = global::HelicopterShooter.Properties.Resources.ShopBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.HeroSkinsPicture);
            this.Controls.Add(this.HeroSkinButton);
            this.Controls.Add(this.PicBackGroundSkinsMenu);
            this.Controls.Add(this.BackGroundSkinsButton);
            this.Controls.Add(this.CloseShopButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            ((System.ComponentModel.ISupportInitialize)(this.PicBackGroundSkinsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeroSkinsPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseShopButton;
        private System.Windows.Forms.Button BackGroundSkinsButton;
        private System.Windows.Forms.PictureBox PicBackGroundSkinsMenu;
        private System.Windows.Forms.Button HeroSkinButton;
        private System.Windows.Forms.PictureBox HeroSkinsPicture;
    }
}