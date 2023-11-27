using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b221210081___NDP_Proje
{
    internal class Surface : Coordinates
    {
        public Surface(int aLength, int aHeight)
        {
            length = aLength;   //x
            height = aHeight;   //y
            width = 0;
        }
    }
}