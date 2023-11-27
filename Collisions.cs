using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b221210081___NDP_Proje
{
    internal class Collisions : Coordinates
    {
        public Collisions() { }

        public new static void CollisionController(Coordinates shape1, Coordinates shape2) //quadrangular - quadrangular
        {
            if (shape1.width == 0 || shape2.width == 0) //two dimensional collisions
            {
                if (Math.Abs((shape1.x + shape1.length / 2) - (shape2.x + shape2.length / 2)) <= (shape2.length / 2 + shape2.length / 2) &&
                    Math.Abs((shape1.y + shape1.height / 2) - (shape2.y + shape2.height / 2)) <= (shape2.height / 2 + shape2.height / 2))
                {
                    MessageBox.Show("TWO DIMENSIONAL COLLISION HAS OCCURED");
                }
                else
                {
                    MessageBox.Show("COLLISION HAS NOT OCCURED");
                }
            }
            else //three dimensional collisions
            {
                if (Math.Abs((shape1.x + shape1.length / 2) - (shape2.x + shape2.length / 2)) <= (shape2.length / 2 + shape2.length / 2) &&
                    Math.Abs((shape1.y + shape1.height / 2) - (shape2.y + shape2.height / 2)) <= (shape2.height / 2 + shape2.height / 2) &&
                    Math.Abs((shape1.z + shape2.width / 2) - (shape2.z + shape2.width / 2)) <= (shape2.width / 2 + shape2.width / 2))
                {
                    MessageBox.Show("THREE DIMENSIONAL COLLISION HAS OCCURED");
                }
                else if (Math.Abs(shape1.x - shape2.x) <= shape2.length / 2 + shape2.length / 2 &&
                    Math.Abs(shape1.y - shape2.y) <= shape2.height / 2 + shape2.height / 2)
                {
                    MessageBox.Show("TWO DIMENSIONAL COLLISION HAS OCCURED BUT\n THREE DIMENSIONAL HAS NOT OCCURED");
                }
                else
                {
                    MessageBox.Show("COLLISION HAS NOT OCCURED");
                }
            }
        }
    }
}