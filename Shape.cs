using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphismExample
{
    public abstract class Shape
    {

        protected Color colour; //shape's colour
        protected int x, y; //note I could use c# properties for this
        public Shape(Color colour, int x, int y)
        {

            this.colour = colour; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos
            //can't provide anything else as "shape" is too general
        }

        public virtual void Draw(Graphics g)
        {
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.NoClip;
            String text = this.ToString();
            g.DrawString(text, drawFont, drawBrush, this.x, this.y, drawFormat);
        }

        public abstract float CalcArea();
        public override string ToString() //get the standard object name and break hierarchy to get just the name, inherited from object class, which is the base class of all classes in C#
        {
            String text = base.ToString();
            String[] sut = text.Split('.');
            text = sut[sut.Length - 1];
            return text;
        }

    }
}
