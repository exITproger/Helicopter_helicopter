using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterShooter
{
    public class Bullet : GameObject
    {
        private const int BulletWidth = 20;
        private const int BulletHeight = 10;
        private const int BulletSpeed = 25;
        private const string BulletTag = "bullet";
        public Bullet(Control container, int startX, int startY)
        {
            Sprite = new PictureBox
            {
                Size = new Size(BulletWidth, BulletHeight),
                BackColor = Color.Maroon,
                Left = startX,
                Top = startY,
                Tag = BulletTag
            };

            container.Controls.Add(Sprite);
            Speed = BulletSpeed;
        }

        public bool IsOutOfScreen(int screenWidth)
        {
            if (Sprite == null)
                return true;

            return Sprite.Left > screenWidth;
        }

        public void Update(List<Obstacle> obstacles)
        {
            if (Sprite == null || Sprite.Parent == null)
                return;

            Sprite.Left += Speed;

            if (CheckCollision(obstacles))
                Destroy();
        }

        public bool CheckCollision(List<Obstacle> obstacles)
        {
            if (Sprite == null || obstacles == null)
                return false;

            foreach (var obstacle in obstacles)
            {
                if (obstacle?.Sprite != null && Sprite.Bounds.IntersectsWith(obstacle.Sprite.Bounds))
                {
                    return true;
                }
            }

            return false;
        }

        public void Destroy()
        {
            if (Sprite != null && Sprite.Parent != null)
            {
                Sprite.Parent.Controls.Remove(Sprite);
                Sprite.Dispose();
                Sprite = null;
            }
        }
    }
}