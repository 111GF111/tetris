using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tetris;


namespace tetris
{
    class Square: Figure 
    { 
                                
        public Square(int a, int b, char sym) 
        {
            points[0] = new Point(a, b, sym);
            points[1] = new Point(a+1, b, sym);
            points[2] = new Point(a, b+1, sym);
            points[3] = new Point(a+1, b+1, sym);

        }

       
                
    }
}
