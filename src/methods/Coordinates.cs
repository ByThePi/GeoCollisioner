using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b221210081___NDP_Proje
{
    public class Coordinates
    {
        Randomizer randNum = new Randomizer();
        public int x, y, z;//coordinates
        public int height; //x
        public int length; //y
        public int width;  //z
        public int radius; //radius, x, y, z
        public Coordinates()
        {
            x = randNum.randomCoordinate();
            y = randNum.randomCoordinate();
            z = randNum.randomCoordinate();
        }

        public virtual void CollisionController(Coordinates shape, Coordinates shape2)
        {

        }
    }
}
