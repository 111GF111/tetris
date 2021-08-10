using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class Stick : Figure
    {
        

        public Stick(int a, int b, char sym) 
        {
            points[0] = new Point(a, b, sym);
            points[1] = new Point(a, b+1, sym);
            points[2] = new Point(a, b+2, sym);
            points[3] = new Point(a, b+3, sym);
            Draw();
        }

        public override void Rotate()
        {
            Hide();
            var clone = Clone();

            if (clone[0].x == clone[1].x)
            {
                RotateHorizont(clone);
            }
            else
            {
                RotateVertical(clone);
            }
            Draw();
        }

        private void RotateVertical(Point[] clone)
        {
            for (int i = 0; i < clone.Length; i++)
            {
                clone[i].x = clone[0].x;
                clone[i].y = clone[0].y + i;
            }
            if (VerifyPosition(clone))
            {
                points = clone;
            }           
                
        }

        private void RotateHorizont(Point[] clone)
        {
            if (clone[0].x == 39|| clone[0].x == 38 || clone[0].x == 37)
            {
                ReverseRotateHorizont(clone);
            }
            else
            {
                for (int i = 0; i < clone.Length; i++)
                {
                    clone[i].y = clone[0].y;
                    clone[i].x = clone[0].x + i;

                }
            }            
            if (VerifyPosition(clone))
            {                
                points = clone;
            }
                
        }

        private void ReverseRotateHorizont(Point[] clone)
        {
            for (int i = 3; i > 0; i--)
            {
                clone[i].y = clone[0].y;
                clone[i].x = clone[i].x - i;
            }
        }

        //private void RotateVertical()
        //{
        //    for (int i = 1; i < points.Length; i++)
        //    {
        //        points[i].x = points[0].x;
        //        points[i].y = points[0].y + i;
        //    }
        //}

        //private void RotateHorizont()
        //{
        //    for (int i = 0; i < points.Length; i++)
        //    {
        //        points[i].y = points[0].y;
        //        points[i].x = points[0].x + i;
        //    }
            
        //}
        
    }
}
