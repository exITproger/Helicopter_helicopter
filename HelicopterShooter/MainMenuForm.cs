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
    public partial class MainMenuForm : Form 
    {
        public MainMenuForm()
        {
            InitializeComponent();
            btnExit.Click += BtnExit_Click;
            DoubleBuffered = true;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            GameForm gamePlayForm = new GameForm();
            Hide();

            gamePlayForm.ShowDialog();
            Show();
        }

        private void BtnShop_Click(object sender, EventArgs e)
        {
            ShopForm shopForm = new ShopForm();
            shopForm.Show();
            Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}