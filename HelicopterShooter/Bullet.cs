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
        public Bullet(Control container, int startX, int startY)
        {
            Sprite = new PictureBox
            {
                Size = new Size(20, 10),
                BackColor = Color.Maroon,
                Left = startX,
                Top = startY,
                Tag = "bullet"
            };

            container.Controls.Add(Sprite);
            Speed = 25;
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