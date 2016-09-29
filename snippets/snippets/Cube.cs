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
        private int width;
        private int height;
        private int depth;

        public int Width
        {
            get { return width; }
        }

        public int Height
        {
            get { return height; }
        }

        public int Depth
        {
            get { return depth; }
        }

        public Cube(int width, int height, int depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1},{2}]", this.Width, this.Height, this.Depth);
        }
    }
}
