using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public class UFO : GameObject
    {
        private const int RespawnDelay = 120; //респаун. МБ стоит поменять время или менять его в ходе игры.

        private readonly Control _container;
        private readonly Image[] _ufoImages;

        private int _currentImageIndex;
        private bool _isDestroyed;
        private int _respawnTimer = 0;

        public UFO(Control container)
        {
            _container = container;

            _ufoImages = new[]
            {
                Properties.Resources.alien1,
                Properties.Resources.alien2,
                Properties.Resources.alien3
            };

            Sprite = new PictureBox
            {
                Size = new Size(110, 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.Transparent,
                Tag = "ufo"
            };

            container.Controls.Add(Sprite);
            Reset();
        }
        public void Update(List<Obstacle> obstacles)
        {
            if (_isDestroyed)
            {
                _respawnTimer++;

                if (_respawnTimer >= RespawnDelay)
                {
                    Reset();
                }

                return;
            }

            Sprite.Left -= Speed;

            foreach (var obstacle in obstacles)
            {
                if (Sprite.Bounds.IntersectsWith(obstacle.Sprite.Bounds))
                {
                    Destroy();
                    break;
                }
            }

            if (Sprite.Right < 0)
                Reset();
        }

        public void Reset()
        {
            _isDestroyed = false;
            _respawnTimer = 0;
            _currentImageIndex = (_currentImageIndex + 1) % _ufoImages.Length;
            Sprite.Image = _ufoImages[_currentImageIndex];
            Sprite.Left = _container.ClientSize.Width;
            Sprite.Top = new Random().Next(20, _container.ClientSize.Height - Sprite.Height);
            Sprite.Visible = true;
        }

        public void Destroy()
        {
            _isDestroyed = true;
            Sprite.Visible = false;
        }
    }
}