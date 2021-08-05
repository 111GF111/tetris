using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            Figure[] f = new Figure[2];
            f[0] = new Square(2, 3, '@');
            f[1] = new Stick(7, 7, '#');

            foreach (var item in f )
            {
                item.Draw();
            }
                        
            Console.ReadKey();



        }
               
    }
}