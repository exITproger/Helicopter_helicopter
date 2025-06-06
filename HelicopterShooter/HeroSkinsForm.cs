using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public partial class HeroSkinsForm : Form
    {

        private int selectedSkin;
        private Dictionary<int, int> skinPrices = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 400},
            {3, 700},
            {4, 1200}
        };



        private void LoadHeroSkinImages()
        {
            picHeroSkinDef.BackgroundImage = Properties.Resources.Helicopter;
            picHeroSkin1.BackgroundImage = Properties.Resources.HeroSkin1;
            picHeroSkin2.BackgroundImage = Properties.Resources.HeroSkin2;
            picHeroSkin3.BackgroundImage = Properties.Resources.HeroSkin3;



            picHeroSkinDef.BackgroundImageLayout = ImageLayout.Stretch;
            picHeroSkin1.BackgroundImageLayout = ImageLayout.Stretch;
            picHeroSkin2.BackgroundImageLayout = ImageLayout.Stretch;
            picHeroSkin3.BackgroundImageLayout = ImageLayout.Stretch;
        }



        public HeroSkinsForm()
        {
            InitializeComponent();
            selectedSkin = Properties.Settings.Default.SelectedHeroSkin;
            this.DoubleBuffered = true;



            LoadHeroSkinImages();

            heroSkin1ActionButton.Click += (s, e) => HandleSkinAction(1);
            heroSkin2ActionButton.Click += (s, e) => HandleSkinAction(2);
            heroSkin3ActionButton.Click += (s, e) => HandleSkinAction(3);
            heroSkin4ActionButton.Click += (s, e) => HandleSkinAction(4);

            CloseShopButton.Click += (s, e) => Close();

            UpdateUI();

            KeyPreview = true;
            KeyDown += HeroSkin_KeyDown;
        }

        private void HeroSkin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }

        private bool IsSkinOwned(int skinId)
        {
            switch (skinId)
            {
                case 1: return Properties.Settings.Default.HeroSkin1Owned;
                case 2: return Properties.Settings.Default.HeroSkin2Owned;
                case 3: return Properties.Settings.Default.HeroSkin3Owned;
                case 4: return Properties.Settings.Default.HeroSkin4Owned;
                default: return false;
            }
        }

        private void SetSkinOwned(int skinId, bool owned)
        {
            switch (skinId)
            {
                case 1: Properties.Settings.Default.HeroSkin1Owned = owned; break;
                case 2: Properties.Settings.Default.HeroSkin2Owned = owned; break;
                case 3: Properties.Settings.Default.HeroSkin3Owned = owned; break;
                case 4: Properties.Settings.Default.HeroSkin4Owned = owned; break;
            }
            Properties.Settings.Default.Save();
        }

        private void HandleSkinAction(int skinId)
        {
            if (!IsSkinOwned(skinId))
            {
                BuySkin(skinId);
            }
            else
            {
                SelectSkin(skinId);
            }
        }

        private void BuySkin(int skinId)
        {
            int price = skinPrices[skinId];
            if (Properties.Settings.Default.TotalCoins >= price)
            {
                Properties.Settings.Default.TotalCoins -= price;
                SetSkinOwned(skinId, true);
                SelectSkin(skinId);
                Properties.Settings.Default.Save();
            }
        }

        private void SelectSkin(int skinId)
        {
            selectedSkin = skinId;
            Properties.Settings.Default.SelectedHeroSkin = skinId;
            Properties.Settings.Default.Save();
            UpdateUI();
        }

        private void UpdateUI()
        {
            UpdateHeroSkinButton(1, heroSkin1ActionButton);
            UpdateHeroSkinButton(2, heroSkin2ActionButton);
            UpdateHeroSkinButton(3, heroSkin3ActionButton);
            UpdateHeroSkinButton(4, heroSkin4ActionButton);

            if (lblCurrentCoins != null)
                lblCurrentCoins.Text = Properties.Settings.Default.TotalCoins.ToString();

            HighlightSelectedSkin();
        }

        private void UpdateHeroSkinButton(int skinId, Button button)
        {
            button.Click -= AllHandlers;

            if (IsSkinOwned(skinId))
            {
                button.Text = (selectedSkin == skinId) ? "Выбран" : "Выбрать";
                button.Enabled = (selectedSkin != skinId);
            }
            else
            {
                button.Text = $"Купить ({skinPrices[skinId]} монет)";
                button.Enabled = Properties.Settings.Default.TotalCoins >= skinPrices[skinId];
            }

            button.Click += (s, e) => HandleSkinAction(skinId);
        }

        private void AllHandlers(object sender, EventArgs e) { }

        private void HighlightSelectedSkin()
        {
            picHeroSkinDef.BackColor = Color.Gray;
            picHeroSkin1.BackColor = Color.Gray;
            picHeroSkin2.BackColor = Color.Gray;
            picHeroSkin3.BackColor = Color.Gray;

            switch (selectedSkin)
            {
                case 1: picHeroSkinDef.BackColor = Color.Cyan; break;
                case 2: picHeroSkin1.BackColor = Color.Cyan; break;
                case 3: picHeroSkin2.BackColor = Color.Cyan; break;
                case 4: picHeroSkin3.BackColor = Color.Cyan; break;
            }
        }
        
        private void picHeroSkinDef_Click(object sender, EventArgs e)
        {
        }
    }
}