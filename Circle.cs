using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b221210081___NDP_Proje
{
    internal class Circle : Coordinates
    {
        public Circle(int aRadius)
        {
            radius = aRadius;     //x, y
            length = aRadius * 2; //x
            height = aRadius * 2;  //y
            width = 0; //z
        }
    }
}
