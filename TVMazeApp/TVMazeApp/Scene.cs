using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVMazeApp
{
    public class Scene
    {
        List<Ball> balls;

        public Scene()
        {
            balls = new List<Ball>();
        }

        public void AddBall(Ball ball)
        {
            balls.Add(ball);
        }

        public void DrawAll(Graphics g)
        {
            foreach (Ball ball in balls)
            {
                ball.Draw(g);
            }
        }
    }
}
