using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b221210081___NDP_Proje
{
    internal class Sphere : Coordinates
    {
        public Sphere(int aRadius)
        {
            radius = aRadius;
            length = aRadius * 2;
            width = aRadius * 2;
            height = aRadius * 2;
        }
    }
}
