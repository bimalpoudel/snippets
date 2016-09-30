using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * @see https://blog.cdemi.io/exploring-visual-studio-15-preview-and-playing-with-c-7/
 */
namespace snippets.snippets
{
    public class Cube
    {
        private int _width;
        private int _height;
        private int _depth;

        public int Width
        {
            get { return _width; }
        }

        public int Height
        {
            get { return _height; }
        }

        public int Depth
        {
            get { return _depth; }
        }

        public Cube(int width, int height, int depth)
        {
            this._width = width;
            this._height = height;
            this._depth = depth;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1},{2}]", this.Width, this.Height, this.Depth);
        }
    }
}
