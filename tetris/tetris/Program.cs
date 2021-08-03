using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);
            //Point p1 = new Point(2,3,'*');
            //p1.Draw();
            //Point p2 = new Point(4,5,'#');
            //p2.Draw();
            //Console.ReadKey();

            Square k1 = new Square (2,5,'*');
            k1.Draw();
            Console.ReadKey();
            Stick s1 = new Stick(9, 10,'#');

            s1.Draw();
            


        }
               
    }
}