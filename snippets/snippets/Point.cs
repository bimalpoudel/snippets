using System;

// http://www.c-sharpcorner.com/article/all-about-c-sharp-7-features/
namespace snippets.snippets
{
    // immutable
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", this.X, this.Y);
        }
    }
}