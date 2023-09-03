using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_formula
{
    public class shapecalculator
    {
        public static shape create(Shapes shapes)
        {

            switch(shapes)
            {
                case Shapes.circle:
                    return new circle();
                case Shapes.rectangle:
                    return new rectangle();
                case Shapes.square:
                    return new square();
                default:
                    throw new ArgumentException("Invalid shape type");


            }
         
            
        }

    }
}
