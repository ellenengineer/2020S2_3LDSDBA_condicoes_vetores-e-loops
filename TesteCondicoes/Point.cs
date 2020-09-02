using System;
using System.Collections.Generic;
using System.Text;

namespace TesteCondicoes
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) =>
            (x, y) = (X, Y);
    }
}
