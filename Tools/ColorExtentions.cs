using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColorExtensions
{
    public static class ColorExtensions
    {
        public static int ToRgb(this Color c)
        {
            return (c.R << 16) + (c.G << 8) + (c.B);
        }

        public static int ToBgr(this Color c)
        {            
            return (c.B << 16) + (c.G << 8) + (c.R);
        }

    }
}