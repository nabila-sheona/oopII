using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_formula
{
    public enum Shapes { circle, square, rectangle }
    public abstract class shape: Icalculator
    {
        //public abstract void draw();
        public abstract double calculatearea();


    }
}
