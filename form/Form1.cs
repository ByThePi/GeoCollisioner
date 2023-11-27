using System.Drawing;

namespace b221210081___NDP_Proje
{
    public partial class Form1 : Form
    {
        Point Point1 = new Point();                                 //radiusish
        Circle Circle1 = new Circle(150);                             //radius
        Circle Circle2 = new Circle(100);                             //radius
        Quadrangle Quadrangle1 = new Quadrangle(150, 50);              //length, height
        Quadrangle Quadrangle2 = new Quadrangle(50, 150);               //length, height        
        Rectangle Rectangle2 = new Rectangle(50, 60);                 //length, height
        Surface Surface1 = new Surface(100, 200);                        //length, height
        Sphere Sphere1 = new Sphere(100);                             //radius
        Sphere Sphere2 = new Sphere(80);                            //radius
        Cylinder Cylinder1 = new Cylinder(60, 100);                   //radius, heigth
        Cylinder Cylinder2 = new Cylinder(60, 120);                   //radius, heigth
        Quadrangular Quadrangular1 = new Quadrangular(150, 150, 100);    //length, heigth, width
        Quadrangular Quadrangular2 = new Quadrangular(100, 100, 100);     //length, heigth, width

        Coordinates Coordi1 = new Coordinates();
        Coordinates Coordi2 = new Coordinates();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] shapes = { "Circle", "Cylinder", "Point", "Quadrangle", "Quadrangular", "Sphere", "Surface" };
            firstShapeComboBox.Items.AddRange(shapes);
            //secondShapeComboBox.Items.AddRange(shapes);
        }

        private void firstShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            if (firstShapeComboBox.Text == "Circle")
            {
                secondShapeComboBox.Items.Clear();
                secondShapeComboBox.Items.Add("Circle");
                Coordi1 = Circle1;
                graphics.DrawEllipse(Pens.Red, Circle1.x, Circle1.y, Circle1.radius * 2, Circle1.radius * 2);
            }
            else if (firstShapeComboBox.Text == "Cylinder")
            {
                secondShapeComboBox.Items.Clear();
                secondShapeComboBox.Items.Add("Cylinder");
                Coordi1 = Cylinder1;
                graphics.DrawEllipse(Pens.Black, Cylinder1.x, Cylinder1.y, Cylinder1.length, Cylinder1.radius);
                graphics.DrawEllipse(Pens.Black, Cylinder1.x, Cylinder1.y + Cylinder1.height, Cylinder1.length, Cylinder1.radius);
                graphics.DrawLine(Pens.Black, Cylinder1.x, Cylinder1.y + Cylinder1.radius / 2,
                                    Cylinder1.x, Cylinder1.y + Cylinder1.height + Cylinder1.radius / 2);
                graphics.DrawLine(Pens.Black, Cylinder1.x + Cylinder1.length, Cylinder1.y + Cylinder1.radius / 2,
                                    Cylinder1.x + Cylinder1.length, Cylinder1.y + Cylinder1.height + Cylinder1.radius / 2);
            }
            else if (firstShapeComboBox.Text == "Point")
            {
                secondShapeComboBox.Items.Clear();
                secondShapeComboBox.Items.Add("Circle");
                secondShapeComboBox.Items.Add("Cylinder");
                secondShapeComboBox.Items.Add("Quadrangle");
                secondShapeComboBox.Items.Add("Rectangle");
                secondShapeComboBox.Items.Add("Sphere");
                Coordi1 = Point1;
                graphics.DrawEllipse(Pens.Red, Point1.x, Point1.y, Point1.length, Point1.height);
            }
            else if (firstShapeComboBox.Text == "Quadrangle")
            {
                secondShapeComboBox.Items.Clear();
                secondShapeComboBox.Items.Add("Quadrangle");
                secondShapeComboBox.Items.Add("Circle");
                Coordi1 = Quadrangle1;
                graphics.DrawRectangle(Pens.Red, Quadrangle1.x, Quadrangle1.y, Quadrangle1.length, Quadrangle1.height);
            }
            else if (firstShapeComboBox.Text == "Quadrangular")
            {
                secondShapeComboBox.Items.Clear();
                secondShapeComboBox.Items.Add("Quadrangular");
                Coordi1 = Quadrangular1;
                graphics.DrawRectangle(Pens.Black, Quadrangular1.x, Quadrangular1.y, Quadrangular1.length, Quadrangular1.height);
                graphics.DrawRectangle(Pens.Black, Quadrangular1.x + 50, Quadrangular1.y + 50, Quadrangular1.length, Quadrangular1.height);

                graphics.DrawLine(Pens.Black, Quadrangular1.x, Quadrangular1.y, Quadrangular1.x + 50, Quadrangular1.y + 50);
                graphics.DrawLine(Pens.Black, Quadrangular1.x + Quadrangular1.length, Quadrangular1.y, Quadrangular1.x + Quadrangular1.length + 50, Quadrangular1.y + 50);
                graphics.DrawLine(Pens.Black, Quadrangular1.x, Quadrangular1.y + Quadrangular1.height, Quadrangular1.x + 50, Quadrangular1.y + Quadrangular1.height + 50);
                graphics.DrawLine(Pens.Black, Quadrangular1.x + Quadrangular1.length, Quadrangular1.y + Quadrangular1.height, Quadrangular1.x + Quadrangular1.length + 50, Quadrangular1.y + Quadrangular1.height + 50);
            }
            else if (firstShapeComboBox.Text == "Sphere")
            {
                secondShapeComboBox.Items.Clear();
                secondShapeComboBox.Items.Add("Cylinder");
                secondShapeComboBox.Items.Add("Quadrangular");
                secondShapeComboBox.Items.Add("Sphere");
                Coordi1 = Sphere1;
                graphics.DrawEllipse(Pens.Red, Sphere1.x, Sphere1.y, Sphere1.radius * 2, Sphere1.radius * 2);
                graphics.DrawEllipse(Pens.Red, Sphere1.x, Sphere1.y + 70, Sphere1.radius * 2, 60);
            }
            else if (firstShapeComboBox.Text == "Surface")
            {
                secondShapeComboBox.Items.Clear();
                secondShapeComboBox.Items.Add("Cylinder");
                secondShapeComboBox.Items.Add("Quadrangular");
                secondShapeComboBox.Items.Add("Sphere");
                Coordi1 = Surface1;
                graphics.DrawRectangle(Pens.Red, Surface1.x, Surface1.y, Surface1.length, Surface1.height);
            }
        }

        private void secondShapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            if (secondShapeComboBox.Text == "Circle")
            {
                Coordi2 = Circle2;
                graphics.DrawEllipse(Pens.Red, Circle2.x, Circle2.y, Circle2.radius * 2, Circle2.radius * 2);
            }
            else if (secondShapeComboBox.Text == "Cylinder")
            {
                Coordi2 = Cylinder2;
                graphics.DrawEllipse(Pens.Black, Cylinder2.x, Cylinder2.y, Cylinder2.length, Cylinder1.radius);
                graphics.DrawEllipse(Pens.Black, Cylinder2.x, Cylinder2.y + Cylinder2.height, Cylinder2.length, Cylinder1.radius);
                graphics.DrawLine(Pens.Black, Cylinder2.x, Cylinder2.y + Cylinder1.radius / 2,
                                    Cylinder2.x, Cylinder2.y + Cylinder2.height + Cylinder1.radius / 2);
                graphics.DrawLine(Pens.Black, Cylinder2.x + Cylinder2.length, Cylinder2.y + Cylinder1.radius / 2,
                                    Cylinder2.x + Cylinder2.length, Cylinder2.y + Cylinder2.height + Cylinder1.radius / 2);
            }
            else if (secondShapeComboBox.Text == "Quadrangle")
            {
                Coordi2 = Quadrangle2;
                graphics.DrawRectangle(Pens.Red, Quadrangle2.x, Quadrangle2.y, Quadrangle2.length, Quadrangle2.height);
            }
            else if (secondShapeComboBox.Text == "Quadrangular")
            {
                Coordi2 = Quadrangular2;
                graphics.DrawRectangle(Pens.Black, Quadrangular2.x, Quadrangular2.y, Quadrangular2.length, Quadrangular2.height);
                graphics.DrawRectangle(Pens.Black, Quadrangular2.x + 50, Quadrangular2.y + 50, Quadrangular2.length, Quadrangular2.height);

                graphics.DrawLine(Pens.Black, Quadrangular2.x, Quadrangular2.y, Quadrangular2.x + 50, Quadrangular2.y + 50);
                graphics.DrawLine(Pens.Black, Quadrangular2.x + Quadrangular2.length, Quadrangular2.y, Quadrangular2.x + Quadrangular2.length + 50, Quadrangular2.y + 50);
                graphics.DrawLine(Pens.Black, Quadrangular2.x, Quadrangular2.y + Quadrangular2.height, Quadrangular2.x + 50, Quadrangular2.y + Quadrangular2.height + 50);
                graphics.DrawLine(Pens.Black, Quadrangular2.x + Quadrangular2.length, Quadrangular2.y + Quadrangular2.height, Quadrangular2.x + Quadrangular2.length + 50, Quadrangular2.y + Quadrangular2.height + 50);
            }
            else if (secondShapeComboBox.Text == "Rectangle")
            {
                Coordi2 = Rectangle2;
                graphics.DrawRectangle(Pens.Red, Rectangle2.x, Rectangle2.y, Rectangle2.length, Rectangle2.height);
            }
            else if (secondShapeComboBox.Text == "Sphere")
            {
                Coordi2 = Sphere2;
                graphics.DrawEllipse(Pens.Red, Sphere2.x, Sphere2.y, Sphere2.radius * 2, Sphere2.radius * 2);
                graphics.DrawEllipse(Pens.Red, Sphere2.x, Sphere2.y + 60, Sphere2.radius * 2, 40);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x1TextBox.Text = Convert.ToString(Coordi1.x);
            y1TextBox.Text = Convert.ToString(Coordi1.y);
            z1TextBox.Text = Convert.ToString(Coordi1.z);

            x2TextBox.Text = Convert.ToString(Coordi2.x);
            y2TextBox.Text = Convert.ToString(Coordi2.y);
            z2TextBox.Text = Convert.ToString(Coordi2.z);

            length1TextBox.Text = Convert.ToString(Coordi1.length);
            height1TextBox.Text = Convert.ToString(Coordi1.height);
            width1TextBox.Text = Convert.ToString(Coordi1.width);
            radius1TextBox.Text = Convert.ToString(Coordi1.radius);

            length2TextBox.Text = Convert.ToString(Coordi2.length);
            height2TextBox.Text = Convert.ToString(Coordi2.height);
            width2TextBox.Text = Convert.ToString(Coordi2.width);
            radius2TextBox.Text = Convert.ToString(Coordi2.radius);

            Collisions.CollisionController(Coordi1, Coordi2);
        }

        public static void CoordinatePrinter(Coordinates shape1, Coordinates shape2)
        {

        }
    }
}
