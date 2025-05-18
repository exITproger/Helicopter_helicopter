using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public class Obstacle : GameObject
    {
        public Obstacle(PictureBox sprite)
        {
            Sprite = sprite;
        }

        public void Update()
        {
            if (Sprite == null || Sprite.Parent == null)
                return;

            Sprite.Left -= Speed;

            if (Sprite.Right < 0)
                Sprite.Left = Sprite.Parent.ClientSize.Width;
        }
    }
}