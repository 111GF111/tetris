using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    public abstract class Figure
    {
        public const int Length = 4;
        protected Point[] points = new Point[4];

        public void Draw()
        {
            foreach (var p in points)
            {
                p.Draw();
            }
        }
        internal void TryMove(Direction dir)
        {
            Hide();
            var clone = Clone();
            Move(clone, dir);
            if (VerifyPosition(clone))
                points = clone;
            Draw();
        }

        protected bool VerifyPosition(Point[] clone)
        {
            foreach (var p in clone)
            {
                if (p.x <0 || p.y <0 || p.x >= Field.WIDTH || p.y >= Field.HEIGHT)
                {
                    return false;
                }
            }
            return true;
        }

        private void Move(Point[] clone, Direction dir)
        {
            foreach (var p in clone)
            {
                p.Move(dir);
            }
        }

        protected Point[] Clone()
        {
            var newPoint = new Point[Length];
            for (int i = 0; i <Length; i++)
            {
                newPoint[i] = new Point (points[i]);
            }
            return newPoint;
        }
        public void Move(Direction dir)
        {
            Hide();
            foreach (var p in points)
            {
                p.Move(dir);
                
            }
            Draw();
        }

        public void Hide() 
        {
            foreach (var p in points)
            {
                p.Hide();
            }
        }
        public abstract void Rotate();

        

        public bool End()
        {
            foreach (var p in points)
            {
                
                if (p.End()==false)
                {
                    return false;
                }   

            }
            return true;
        }


    }
}
