using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphismExample
{
    public class Triangle : Shape
    {
        protected int size;
        public Triangle(Color colour, int x, int y, int size) : base(colour, x, y)
        {
            this.size = size;
        }
        public override void Draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            Point[] points = { new Point(x, y + size), new Point(x + size / 2, y), new Point(x + size, y + size) };
            g.FillPolygon(b, points);
            g.DrawPolygon(p, points);
            base.Draw(g);
        }
    }
}
