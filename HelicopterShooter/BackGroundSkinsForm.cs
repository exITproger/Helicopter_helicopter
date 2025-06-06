using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public partial class BackGroundSkinsForm : Form
    {
        private int selectedSkin;

        private bool IsSkinOwned(int skinId)
        {
            switch (skinId)
            {
                case 1: return Properties.Settings.Default.Skin1Owned;
                case 2: return Properties.Settings.Default.Skin2Owned;
                case 3: return Properties.Settings.Default.Skin3Owned;
                case 4: return Properties.Settings.Default.Skin4Owned;
                default: return false;
            }
        }


        private void SetSkinOwned(int skinId, bool owned)
        {
            switch (skinId)
            {
                case 1: Properties.Settings.Default.Skin1Owned = owned; break;
                case 2: Properties.Settings.Default.Skin2Owned = owned; break;
                case 3: Properties.Settings.Default.Skin3Owned = owned; break;
                case 4: Properties.Settings.Default.Skin4Owned = owned; break;
            }
        }


        private Dictionary<int, int> skinPrices = new Dictionary<int, int>()
        {
            {1, 0},
            {2, 300},
            {3, 500},
            {4, 1000}
        };

        public BackGroundSkinsForm()
        {
            InitializeComponent();
            selectedSkin = Properties.Settings.Default.SelectedBackgroundSkin;
            this.DoubleBuffered = true;
            // Устанавливаем обработчики
            BackGround1ActionButton.Click += (s, e) => HandleSkinAction(1);
            BackGround2ActionButton.Click += (s, e) => HandleSkinAction(2);
            BackGround3ActionButton.Click += (s, e) => HandleSkinAction(3);
            BackGround4ActionButton.Click += (s, e) => HandleSkinAction(4);
            UpdateUI();

            KeyPreview = true;
            KeyDown += BackGroundSkinsForm_KeyDown;
        }
        private void BackGroundSkinsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
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
                Properties.Settings.Default.Save();
                UpdateUI();
            }
        }

        private void SelectSkin(int skinId)
        {
            selectedSkin = skinId;
            Properties.Settings.Default.SelectedBackgroundSkin = skinId;
            Properties.Settings.Default.Save();
            UpdateUI();
        }

        private void UpdateUI()
        {
            UpdateBackGroundButton(1, BackGround1ActionButton);
            UpdateBackGroundButton(2, BackGround2ActionButton);
            UpdateBackGroundButton(3, BackGround3ActionButton);
            UpdateBackGroundButton(4, BackGround4ActionButton);

            lblCurrentCountCoints.Text = Properties.Settings.Default.TotalCoins.ToString();
            HighlightSelectedSkin();
        }

        private void UpdateBackGroundButton(int skinId, Button button)
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
            this.DoubleBuffered = true;
            picBackGroundDefault.BackColor = Color.Gray;
            PictureBackGroundSkin1.BackColor = Color.Gray;
            PictureBackGroundSkin2.BackColor = Color.Gray;
            PictureBackGroundSkin3.BackColor = Color.Gray;

            switch (selectedSkin)
            {
                case 1: picBackGroundDefault.BackColor = Color.Cyan; break;
                case 2: PictureBackGroundSkin1.BackColor = Color.Cyan; break;
                case 3: PictureBackGroundSkin2.BackColor = Color.Cyan; break;
                case 4: PictureBackGroundSkin3.BackColor = Color.Cyan; break;
            }
        }

        private void CloseBackGroundSkins_Click(object sender, EventArgs e)
        {
            //new ShopForm().Show();
            this.Close();
        }
    }
}
