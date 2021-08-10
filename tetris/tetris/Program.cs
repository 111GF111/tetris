using System;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Field.WIDTH, Field.HEIGHT);
            Console.SetBufferSize(Field.WIDTH, Field.HEIGHT);                                      
            ConsoleKeyInfo click;
            Direction dir;
            do
            {
                FigureGenerator generator = new FigureGenerator(20, 0, '*');
                Figure s = generator.GetNewFigure();
                
                do
                {

                    click = Console.ReadKey();

                    switch (click.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            dir = Direction.left;                            
                            s.TryMove(dir);                           
                            break;
                        case ConsoleKey.RightArrow:
                            dir = Direction.right;                           
                            s.TryMove(dir);                           
                            break;
                        case ConsoleKey.UpArrow:                                                     
                            s.Rotate();                           
                            break;
                        case ConsoleKey.DownArrow:
                            dir = Direction.down;                          
                            s.TryMove(dir);                          
                            break;
                        default:
                            break;
                    }


                } while (s.End());
            } while (true);
            


            Console.ReadKey();



        }
               
    }
}