using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public partial class ShopForm : Form
    {

        public ShopForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            KeyPreview = true;
            KeyDown += ShopForm_KeyDown;
        }

        private void ShopForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainMenuForm mainMenu = new MainMenuForm();
                mainMenu.Show();
                Close();
            }
        }

        private void BackGroundSkinsButton_Click(object sender, EventArgs e)
        {
            BackGroundSkins backgroundskins = new BackGroundSkins();
            backgroundskins.Show();
            Hide();
        }

        private void CloseShopButton_click(object sender, EventArgs e)
        {
            MainMenuForm mainMenu = new MainMenuForm();
            mainMenu.Show();
            Close();
        }
    }
}