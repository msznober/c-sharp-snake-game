using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_snake_game
{
    public class gridReference
    {
        public gridReference()
        {
            X = 0;
            Y = 0;
        }

        public gridReference(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }

        public int Y { get; set; }
    }
}
