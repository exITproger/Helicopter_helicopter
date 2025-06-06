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
        private const int MinHeight = 80;

        private bool _scored = false;
        private static int topObstacleHeight = 0;
        private static int holeHeight = 200;

        public bool IsTopObstacle { get; set; }

        public Obstacle(PictureBox sprite, bool isTop)
        {
            Sprite = sprite;
            IsTopObstacle = isTop;
        }

        public void Update()
        {
            if (Sprite == null || Sprite.Parent == null)
                return;

            _lastX = Sprite.Left; // Запоминаем позицию ДО перемещения
            Sprite.Left -= Speed;

            if (Sprite.Right < 0)
                Reset();
        }

        public void Reset()
        {
            if (Sprite?.Parent == null)
                return;

            Sprite.Left = Sprite.Parent.ClientSize.Width;

            int totalHeight = Sprite.Parent.ClientSize.Height;
            int minHeight = MinHeight;
            int maxTopHeight = totalHeight - holeHeight - minHeight;

            if (IsTopObstacle)
            {
                var rand = new Random();
                topObstacleHeight = rand.Next(minHeight, maxTopHeight + 1);

                Sprite.Height = topObstacleHeight;
                Sprite.Top = 0;
            }
            else
            {
                int bottomHeight = totalHeight - topObstacleHeight - holeHeight;
                Sprite.Height = bottomHeight;
                Sprite.Top = totalHeight - bottomHeight;
            }

            _scored = false;
        }

        private int _lastX; // Сохраняем позицию предыдущего кадра

        public bool ShouldScore(int playerLeft)
        {
            if (_scored || Sprite == null)
                return false;

            // Если труба где-то рядом с игроком — засчитываем
            if (Sprite.Right <= playerLeft + 10) // +10 пикселей "запаса"
            {
                _scored = true;
                return true;
            }

            return false;
        }
    }



}