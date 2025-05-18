using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public class GameEngine
    {
        private readonly Form _gameForm;

        private readonly Control _container;
        private readonly Player _player;
        private readonly UFO _ufo;
        private readonly List<Obstacle> _obstacles;
        private readonly List<Bullet> _bullets;
        private readonly Timer _gameTimer;
        private readonly Random _random = new Random();

        private int _score;
        private bool _gameIsOver;

        public event Action<int> ScoreUpdated;
        public event Action<int> GameOver;

        public GameEngine(
            Control container, Form gameForm,
            PictureBox playerSprite, PictureBox obstacleSprite1,
            PictureBox obstacleSprite2
            )
        {
            _container = container;
            _gameForm = gameForm;

            _player = new Player(playerSprite);
            _ufo = new UFO(container);

            _obstacles = new List<Obstacle>
            {
                new Obstacle(obstacleSprite1),
                new Obstacle(obstacleSprite2)
            };

            _bullets = new List<Bullet>();

            _gameTimer = new Timer { Interval = 20 };
            _gameTimer.Tick += UpdateGame;

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

            foreach (var obstacle in _obstacles) obstacle.Update();
            foreach (var bullet in _bullets.ToArray()) bullet.Update(_obstacles);

            CheckCollisions();
            RemoveInactiveBullets();

            AdjustDifficulty();
        }

        private void Shoot()
        {
            var bullet = new Bullet(_container, _player.Right, _player.Top + _player.Height / 2);
            _bullets.Add(bullet);
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
            _ufo.Speed = 10 + _score / 5;

            foreach (var obstacle in _obstacles)
            {
                obstacle.Speed = 8 + _score / 10;
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
            Properties.Settings.Default.TotalCoins += _score;
            GameOver?.Invoke(_score);

        }

        private void ResetGame()
        {
            //_score = 0;
            _gameIsOver = false;

            _player.Reset();
            _ufo.Reset();

            foreach (var bullet in _bullets)
                bullet.Destroy();

            _bullets.Clear();

            ScoreUpdated?.Invoke(_score);
            _gameTimer.Start();
        }
    }
}