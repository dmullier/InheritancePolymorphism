using System.Collections;
using System.Diagnostics;

namespace InheritancePolymorphismExample
{
    public partial class Form1 : Form
    {
        ArrayList Shapes = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            //add a few shapes
            Shapes.Add(new Circle(Color.Purple, 10, 100, 100)); //create a red circle at (10,100) of radius 100
            Shapes.Add(new Circle(Color.Chartreuse, 100, 10, 50)); //apparently it's green
            Shapes.Add(new Rect(Color.Blue, 150, 150, 50, 100)); //rect now appears behind last circle.
            Shapes.Add(new Circle(Color.Red, 10, 100, 100));
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
                Debug.WriteLine(s); //note passing a reference to Write will automatucally call its ToString() (same in Java C++ etc).

            }
            
        }
    }
    
}
