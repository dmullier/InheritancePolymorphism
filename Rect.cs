using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphismExample
{
    public class Rect : Shape
    {
        protected int width, height; //should be declared as protected for an classes that inherit from this class
       
        public Rect(Color colour, int x, int y, int width, int height) : base(colour, x, y)
        {
            this.width = width;
            this.height = height;
        }

        public void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillRectangle(b, x, y, width, height);
            g.DrawRectangle(p, x, y, width, height);

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
