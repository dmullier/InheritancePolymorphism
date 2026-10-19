using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancePolymorphismExample
{
    public interface IShape
    {
        void Draw(Graphics g);
        float CalcArea();
    }
}
