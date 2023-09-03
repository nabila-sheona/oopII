using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_formula
{
    public class square: shape
    {
        public int l { get; set; }
        public int x { get; set; }
        public int y { get; set; }



        public override double calculatearea()
        {
            return l*l;
        }

       // public override void draw()
        //{
          //  Console.WriteLine($"Drawing a sqaure at ({x},{y}) with side length {l}");
        //}
    }
}
