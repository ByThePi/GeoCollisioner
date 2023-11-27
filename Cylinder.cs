using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b221210081___NDP_Proje
{
    internal class Cylinder : Coordinates
    {
        public Cylinder(int aRadius, int aHeight)
        {
            radius = aRadius;       //x, z
            length = aRadius * 2;   //x
            width = aRadius * 2;    //z
            height = aHeight;       //y
        }
    }
}