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
            
            if (dir == Direction.left)
            {
                x -= 1; 
            }

            if (dir == Direction.right)
            {
                x += 1;
            }
            if (dir == Direction.down)
            {
                
                y += 1;
                
            }
        }

        internal void Hide()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(" ");
        }
    }
}
