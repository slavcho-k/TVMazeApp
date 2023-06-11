using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class Ball
    {
        int size;
        Point center;

        public Ball(int size, Point center)
        {
            this.size = size;
            this.center = center;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Black);
            g.FillEllipse(b, center.X - size, center.Y - size, size * 2, size * 2);
            b.Dispose();
        }

        public void Pulse()
        {
            switch(size)
            {
                case 10: size = 15; break;
                case 15: size = 20; break;
                default: size = 10; break;
            }
        }
    }
}
