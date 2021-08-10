using System;

namespace tetris
{
    internal class FigureGenerator
    {
        private int _x;
        private int _y;
        private char _c;

        public FigureGenerator(int x, int y, char c)
        {
            _x = x;
            _y = y;
            _c = c;
        }

        internal Figure GetNewFigure()
        {
            Random _rand = new Random();
            if (_rand.Next(0,2)==0)
            {
                return new Stick(_x, _y, _c);
            }
            else
            {
                return new Square(_x, _y, _c);
            }
        }
    }
}