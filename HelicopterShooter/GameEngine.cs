using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing; 

namespace HelicopterShooter
{
    public class GameEngine
    {
        private const int BaseUfoSpeed = 10;
        private const int UfoSpeedIncreasePerScore = 5;
        private const int BaseObstacleSpeed = 8;
        private const int ObstacleSpeedIncreasePerScore = 10;

        private readonly Form _gameForm;
        private readonly Control _container;
        private readonly Player _player;
        private readonly UFO _ufo;
        private readonly List<Obstacle> _obstacles;
        private readonly List<Bullet> _bullets;
        private readonly Timer _gameTimer;
        private readonly Timer _explosionTimer = new Timer { Interval = 1500 }; // 1.5 секунды
        private readonly Random _random = new Random();
        private readonly PictureBox _explosion;

        private int _score;
        private bool _gameIsOver;
        private int _shootCooldown = 1000;
        private DateTime _lastShotTime = DateTime.MinValue;

        public event Action<int> ScoreUpdated;
        public event Action<int> GameOver;



        private Dictionary<int, Image> _heroSkins;



        public GameEngine(
            Control container, Form gameForm,
            PictureBox playerSprite, PictureBox obstacleSprite1,
            PictureBox obstacleSprite2, PictureBox explosion
            )
        {
            _container = container;
            _gameForm = gameForm;

            _player = new Player(playerSprite);
            _ufo = new UFO(container);

            _obstacles = new List<Obstacle>
            {
                new Obstacle(obstacleSprite1, true),
                new Obstacle(obstacleSprite2, false)
            };

            _explosion = explosion;
            _explosion.Visible = false; // скрываем по умолчанию

            _bullets = new List<Bullet>();

            _gameTimer = new Timer { Interval = 20 };
            _gameTimer.Tick += UpdateGame;

            _explosionTimer.Tick += (s, e) =>
            {
                _explosion.Visible = false;
                _explosionTimer.Stop();
            };



            _heroSkins = new Dictionary<int, Image>
            {
                {1, Properties.Resources.Helicopter},
                {2, Properties.Resources.HeroSkin1},
                {3, Properties.Resources.HeroSkin2},
                {4, Properties.Resources.HeroSkin3}
            };

            int selectedSkin = Properties.Settings.Default.SelectedHeroSkin;
            if (_heroSkins.ContainsKey(selectedSkin))
            {
                playerSprite.Image = _heroSkins[selectedSkin];
            }



            ResetGame();
        }

        public void HandleKeyDown(Keys key)
        {
            if (key == Keys.Escape)
            {
                _gameForm.Close();
            }

            if (_gameIsOver && key == Keys.Enter)
            {
                ResetGame();

                return;
            }

            switch (key)
            {
                case Keys.Up:
                    _player.MoveUp();
                    break;

                case Keys.Down:
                    _player.MoveDown();
                    break;

                case Keys.Space:
                    Shoot();
                    break;

                case Keys.Escape:

                    _container.FindForm()?.Close();
                    break;
            }
        }

        public void HandleKeyUp(Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    _player.StopMovingUp();
                    break;

                case Keys.Down:
                    _player.StopMovingDown();
                    break;
            }
        }

        private void UpdateGame(object sender, EventArgs e)
        {

            _player.Update();
            _ufo.Update(_obstacles);

            foreach (var obstacle in _obstacles)
            {
                obstacle.Update();

                if (obstacle.ShouldScore(_player.Left))
                {
                    IncreaseScore();
                }
            }
            foreach (var bullet in _bullets.ToArray()) bullet.Update(_obstacles);

            CheckCollisions();
            RemoveInactiveBullets();

            AdjustDifficulty();


        }

        private void Shoot()
        {
            if (_gameIsOver) return; // После смерти стрелять вздумал???

            if ((DateTime.Now - _lastShotTime).TotalMilliseconds < _shootCooldown)
                return; // еще рано стрелять

            var bullet = new Bullet(_container, _player.Right, _player.Top + _player.Height / 2);
            _bullets.Add(bullet);
            _lastShotTime = DateTime.Now;
        }

        private void CheckCollisions()
        {
            if (_player.CollidesWith(_ufo)) EndGame();

            foreach (var obstacle in _obstacles)
            {
                if (_player.CollidesWith(obstacle)) EndGame();

                foreach (var bullet in _bullets.ToArray())
                {
                    if (bullet.CollidesWith(_ufo))
                    {
                        _bullets.Remove(bullet);
                        bullet.Destroy();
                        IncreaseScore();
                        _ufo.Reset();

                        break;
                    }

                    if (bullet.CollidesWith(obstacle))
                    {
                        _bullets.Remove(bullet);
                        bullet.Destroy();

                        break;
                    }
                }
            }
        }

        private void RemoveInactiveBullets()
        {
            foreach (var bullet in _bullets.ToArray())
            {
                if (bullet.IsOutOfScreen(_container.Width))
                {
                    _bullets.Remove(bullet);
                    bullet.Destroy();
                }
            }
        }

        private void AdjustDifficulty()
        {
            _ufo.Speed = BaseUfoSpeed + _score / UfoSpeedIncreasePerScore;

            foreach (var obstacle in _obstacles)
            {
                obstacle.Speed = BaseObstacleSpeed + _score / ObstacleSpeedIncreasePerScore;
            }
        }

        private void IncreaseScore()
        {
            _score++;
            ScoreUpdated?.Invoke(_score);
        }

        private void EndGame()
        {
            _gameTimer.Stop();
            _gameIsOver = true;

            ShowExplosion();
            _player.Hide(); // Скрываем игрока после взрыва
            _ufo.Hide();// спрятали при столкновении с игроком
            Properties.Settings.Default.TotalCoins += _score;
            GameOver?.Invoke(_score);
        }
        private void ShowExplosion()
        {
            _explosion.Left = _player.Left;
            _explosion.Top = _player.Top;
            _explosion.Visible = true;
            _explosion.SendToBack();
            _explosionTimer.Start();
        }
        private void ResetGame()
        {
            _explosion.Visible = false;

            _score = 0;
            _gameIsOver = false;

            _player.Reset();
            _ufo.Show(); //вернули ufo
            _player.Show(); // Возвращаем игрока
            _ufo.Reset();

            foreach (var bullet in _bullets)
                bullet.Destroy();
            _bullets.Clear();

            foreach (var obstacle in _obstacles)
                obstacle.Reset();

            ScoreUpdated?.Invoke(_score);
            _gameTimer.Start();
        }

    }
}