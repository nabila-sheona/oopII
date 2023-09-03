using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape_formula
{
    public class circle: shape
    {
        public int r { get; set; }
        public int x { get; set; }
        public int y { get; set; }

  
        public override double calculatearea()
        {
            return .5 * 3.1416 * r * r;
        }

        //public override void draw()
        //{
          //  Console.WriteLine($"Drawing a circle at ({x},{y}) with radius {r}");
        //}
    }
}
