using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    internal class Cube
    {

        int side;
        
        public Cube(int side)
        {
               this.side = side;
        }
        public void getVolume()
        {
            int volume = side * side * side;
            Console.Write("Volume of Cube:"+volume);

        }
    }
}
