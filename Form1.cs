using System.Collections;
using System.Diagnostics;

namespace InheritancePolymorphismExample
{
    public partial class Form1 : Form
    {
        ArrayList Circles = new ArrayList();
        ArrayList Rectangles = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            //add a few shapes
            Circles.Add(new Circle(Color.Purple, 10, 100, 100)); //create a red circle at (10,100) of radius 100
            Circles.Add(new Circle(Color.Chartreuse, 100, 10, 50)); //apparently it's green
            Rectangles.Add(new Rect(Color.Blue, 150, 150, 50, 100));
            Circles.Add(new Circle(Color.Red, 10, 100, 100));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("paint called");
            Graphics g = e.Graphics;


            for (int i = 0; i < Circles.Count; i++)
            {
                Circle c;

                c = (Circle) Circles[i];
                c.Draw(g);
                Debug.WriteLine(c); //note passing a reference to Write will automatucally call its ToString() (same in Java C++ etc).

            }
            for (int i = 0; i < Rectangles.Count; i++)
            {
                Rect r;

                r = (Rect)Rectangles[i];
                r.Draw(g);
                Debug.WriteLine(r);

            }
        }
    }
    
}
