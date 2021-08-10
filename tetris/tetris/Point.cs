using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    public class Point
    {
        public int x;
        public int y;
        public char c;

        public void Draw() 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(c);
            Console.SetCursorPosition(0, 0);
        }
        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            c = p.c;

        }
        public Point(int a, int b, char sym)
        {
            x = a;
            y = b;
            c = sym;
        }
        public Point() { }
        public void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.left:
                    x -= 1;
                    break;
                case Direction.right:
                    x += 1;                    
                    break;
                case Direction.down:
                    y += 1;
                    break;
                default:
                    break;
            }

        }

        internal bool End()
        {
            if (y == 29)
            {
               return false;
            }
            return true;
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
