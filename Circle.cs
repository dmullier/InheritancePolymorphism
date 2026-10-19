using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphismExample
{
    public class Circle : Shape
    {
        protected int radius; //should be declared as protected for an classes that inherit from this class

        public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
        {
            this.radius = radius;
        }

        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillEllipse(b, x, y, radius * 2, radius * 2);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);
            base.Draw(g); //call the base class draw method to draw the name of the shape
        }

        public override string ToString() //get the standard object name and break hierarchy to get just the name
        {
            String text = base.ToString();
            String[] sut = text.Split('.');
            text = sut[sut.Length - 1];
            return text;
        }

    }
}
