using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphismExample
{
    public class Square : Rect
    {
        protected int size;
        public Square(Color colour, int x, int y, int size) : base(colour, x, y, size, size)
        {
            this.size = size;
        }

        //no draw method here because it is provided by the parent class Rectangle


    }
}
