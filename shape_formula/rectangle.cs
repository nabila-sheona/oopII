using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_formula
{
    public class rectangle: shape
    {
        public int l { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
       
      
        public override double calculatearea()
        {
            return l*w;
        }

        //public override void draw()
        //{
          //  Console.WriteLine($"Drawing a rectangle at ({x},{y}) with length {l} and width {w}");
        //}
    }
}
