/**************************************************************************** 
**                  SAKARYA ÜNÝVERSÝTESÝ           
**          BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ 
**               BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**                  PROGRAMLAMAYA GÝRÝÞÝ DERSÝ 
**
**             ÖDEV NUMARASI    : 1. Proje/Tasarým
**             ÖÐRENCÝ ADI      : Enes SOYLU
**             ÖÐRENCÝ NUMARASI : B221210081 
**             DERS GRUBU       : C Grubu
               YOUTUBE LÝNKÝ    : 
****************************************************************************/
namespace b221210081___NDP_Proje
{
    internal static class Program
    {


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            //Point Point1 = new Point();                                 //radiusish
            //Circle Circle1 = new Circle(5);                             //radius
            //Circle Circle2 = new Circle(4);                             //radius
            //Quadrangle Quadrangle1 = new Quadrangle(4, 5);              //length, height
            //Rectangle Rectangle1 = new Rectangle(3, 4);                 //length, height
            //Rectangle Rectangle2 = new Rectangle(5, 6);                 //length, height
            //Surface Surface1 = new Surface(7, 8);                        //length, height
            //Sphere Sphere1 = new Sphere(9);                             //radius
            //Sphere Sphere2 = new Sphere(12);                            //radius
            //Cylinder Cylinder1 = new Cylinder(6, 11);                   //radius, heigth
            //Cylinder Cylinder2 = new Cylinder(4, 3);                    //radius, heigth
            //Quadrangular Quadrangular1 = new Quadrangular(7, 12, 9);    //length, heigth, width
            //Quadrangular Quadrangular2 = new Quadrangular(4, 6, 2);     //length, heigth, width
        }

        static void ShapeCoordinate(Coordinates shape, string name)
        {
            Console.WriteLine("\n" + name + "'s x: " + shape.x);
            Console.WriteLine(name + "'s y: " + shape.y);
            Console.WriteLine(name + "'s z: " + shape.z);
        }
    }
}