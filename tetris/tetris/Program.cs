using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(40,30);
            //Console.SetBufferSize(40,30);
            int x1 = 2;
            int y1 = 3;
            char c1 = '*';
            Console.SetCursorPosition(x1,y1);
            Console.WriteLine(c1);
            Drow(5,5,'#');
            Drow(6, 5, '#');
            Drow(7, 5, '#');
            Drow(8, 5, '#');
            Console.ReadKey();
            



        }

        static void Drow(int x, int y, char c)
        {
            Console.SetCursorPosition(x,y);
            Console.WriteLine(c);
        }
    }
}