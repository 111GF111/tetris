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
            f[0] = new Square(15, 0, '@');
            f[1] = new Stick(7, 7, '#');

            ////foreach (var item in f)
            ////{
            ////     
            ////}
            ////Enums movent = Enums.left;
            ///
            ////Console.WriteLine((int)movent);
            f[0].Draw();
            ConsoleKeyInfo click;
            Direction dir;
            do
            {
                
                for (int i = 0; i < 5; i++)
                {

                    click = Console.ReadKey();
                    if (click.Key == ConsoleKey.LeftArrow)
                    {
                        dir = Direction.left;
                        f[0].Hide();
                        f[0].Move(dir);
                        f[0].Draw();
                    }

                    if (click.Key == ConsoleKey.RightArrow)
                    {
                        dir = Direction.right;
                        f[0].Hide();
                        f[0].Move(dir);
                        f[0].Draw();
                    }
                    if (click.Key == ConsoleKey.DownArrow)
                    {
                        dir = Direction.down;
                        f[0].Hide();
                        f[0].Move(dir);
                        f[0].Draw();
                    }
                }

            } while (true);


            Console.ReadKey();



        }
               
    }
}