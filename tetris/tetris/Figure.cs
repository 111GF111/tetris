using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    public class Figure
    {
        protected Point[] points = new Point[4];

        public void Draw()
        {
            foreach (var p in points)
            {
                p.Draw();
            }
        }
        public void Move(Direction dir)
        {
            foreach (var p in points)
            {
                p.Move(dir);
            }
        }

        public void Hide() 
        {
            foreach (var p in points)
            {
                p.Hide();
            }
        }

    }
}
