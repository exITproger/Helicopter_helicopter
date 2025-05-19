using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public abstract class GameObject
    {
        public PictureBox Sprite { get; protected set; }
        public int Speed { get; set; }

        public int Top => Sprite.Top;
        public int Left => Sprite.Left;
        public int Right => Sprite.Right;
        public int Bottom => Sprite.Bottom;
        public int Width => Sprite.Width;
        public int Height => Sprite.Height;

        public bool CollidesWith(GameObject other)
        {
            if (Sprite == null || other?.Sprite == null)
                return false;

            return Sprite.Bounds.IntersectsWith(other.Sprite.Bounds);
        }


    }
}
