using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

          Console.SetBufferSize(150,95);

            HorizontalLine lineUp = new HorizontalLine(0, 78, 0, '+');
            lineUp.Drow();
            HorizontalLine LineDown = new HorizontalLine(0, 78, 24, '+');
            LineDown.Drow();
            VerticalLine LeftLine = new VerticalLine(0, 0, 24, '+');
            LeftLine.Drow();
            VerticalLine RightLine = new VerticalLine(78, 0, 24, '+');
            RightLine.Drow();




            Console.ReadLine();

        }


    }
}
