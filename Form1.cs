using System.Collections;
using System.Diagnostics;

namespace InheritancePolymorphismExample
{
    public partial class Form1 : Form
    {
        List<Shape> Shapes = new List<Shape>();
        public Form1()
        {
            InitializeComponent();
            //Shapes.Add("hello"); //this would cause a problem but if we uncomment it we won't get a syntax error, go on try it. NOTE that now you get a syntax error, where before you got a run-time error
            Random rand = new Random(77887);
            for (int i = 0; i < 150; i++)
            {
                int x = rand.Next(Size.Width);
                int y = rand.Next(Size.Height);
                int size = rand.Next(250)+10;  //minimum size of 10 to avoid zero size shapes

                int red = rand.Next(255);
                int green = rand.Next(255);
                int blue = rand.Next(255);

                Color newColour = Color.FromArgb(128, red, green, blue); //128 is semi transparent

                int shape = rand.Next(4);

                switch (shape)
                {
                    case 0:
                        Shapes.Add(new Circle(newColour, x, y, size));
                        break;
                    case 1:
                        Shapes.Add(new Square(newColour, x, y, size));
                        break;
                    case 2:
                        Shapes.Add(new Rect(newColour, x, y, size, size / 2));
                        break;
                    case 3:
                        Shapes.Add(new Triangle(newColour, x, y, size));
                        break;


                }
            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("paint called");
            Graphics g = e.Graphics;


            for (int i = 0; i < Shapes.Count; i++)
            {
               Shape s;

                s = (Shape) Shapes[i];
                s.Draw(g);
                Debug.WriteLine(s + " area is " + s.CalcArea()); //note passing a reference to Write will automatucally call its ToString() (same in Java C++ etc).

            }
            
        }
    }
    
}
