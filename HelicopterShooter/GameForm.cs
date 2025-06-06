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
    public partial class GameForm : Form
    {
        private readonly GameEngine _gameEngine;



        private Dictionary<int, Image> _heroSkins = new Dictionary<int, Image>();




        public GameForm()
        {
            InitializeComponent();
            KeyPreview = true;
            _gameEngine = new GameEngine(this, this, picPlayer, pillar1, pillar2, picExplosion);
            _gameEngine.ScoreUpdated += OnScoreUpdated;
            _gameEngine.GameOver += OnGameOver;

            KeyDown += GameForm_KeyDown;
            KeyUp += GameForm_KeyUp;
            Load += GameForm_Load;



            _heroSkins.Add(1, Properties.Resources.Helicopter);
            _heroSkins.Add(2, Properties.Resources.HeroSkin1);
            _heroSkins.Add(3, Properties.Resources.HeroSkin2);
            _heroSkins.Add(4, Properties.Resources.HeroSkin3);



        }

        //private void OnScoreUpdated(int score) => txtScore.Text = $"Score: {score}";
        private void OnScoreUpdated(int score)
        {
            txtScore.Text = $"Score: {score}";
            txtScore.BringToFront();
        }
        private void OnGameOver(int score) => txtScore.Text = $"Score: {score} Game over, press enter to retry!";

        private void GameForm_KeyDown(object sender, KeyEventArgs e) => _gameEngine.HandleKeyDown(e.KeyCode);
        private void GameForm_KeyUp(object sender, KeyEventArgs e) => _gameEngine.HandleKeyUp(e.KeyCode);


        private void GameForm_Load(object sender, EventArgs e)
        {
            int selectedSkin = Properties.Settings.Default.SelectedBackgroundSkin;
            switch (selectedSkin)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.BackGroundMainInGame;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.BackGround1InGame;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.BackGround2InGame;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.BackGround3InGame;
                    break;
                default:
                    this.BackgroundImage = Properties.Resources.BackGroundMainInGame;
                    break;
            }

            this.BackgroundImageLayout = ImageLayout.Stretch;



            int selectedHeroSkin = Properties.Settings.Default.SelectedHeroSkin;
            if (_heroSkins.ContainsKey(selectedHeroSkin))
            {
                picPlayer.Image = _heroSkins[selectedHeroSkin];
            }
            else
            {
                picPlayer.Image = Properties.Resources.Helicopter;
            }



        }

    }
}