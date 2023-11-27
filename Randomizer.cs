using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b221210081___NDP_Proje
{
    public class Randomizer
    {
        Random rnd;
        public Randomizer()
        {
            rnd = new Random();
        }

        public int randomCoordinate()
        {
            return rnd.Next(0, 400);
        }
    }
}