using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public class Player : GameObject
    {
        private const int PlayerSpeed = 15;

        private bool _movingUp, _movingDown;

        public Player(PictureBox existingSprite)
        {
            Sprite = existingSprite;
            Reset();
        }

        public void MoveUp() => _movingUp = true;

        public void MoveDown() => _movingDown = true;

        public void StopMovingUp() => _movingUp = false;

        public void StopMovingDown() => _movingDown = false;

        public void Update()
        {
            if (_movingUp && Top > 0)
                Sprite.Top -= PlayerSpeed;

            if (_movingDown && Bottom < Sprite.Parent.ClientSize.Height)
                Sprite.Top += PlayerSpeed;
        }

        public void Reset()
        {
            Sprite.Top = 540;
            Sprite.Left = 5;
            _movingUp = _movingDown = false;
        }
    }
}