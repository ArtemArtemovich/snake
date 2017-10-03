using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {


            HorizotalLine line = new HorizotalLine( 1, 10, 8, '+' );
            line.Drow();

            VerticalLine line1 = new VerticalLine( 1, 40, 1, '+' );
            line1.Drow();
            
            Console.ReadLine();
        }
    }
}
