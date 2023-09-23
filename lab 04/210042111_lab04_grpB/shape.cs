using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210042111_lab04_grpB
{
    using System;
    using System.Collections.Generic;

    // ShapeType enum to represent the types of shapes
    public enum ShapeType
    {
        Circle,
        Rectangle,
        Square
    }


    // Abstract base class for shapes
    public abstract class Shape
    {
         public double x, y, sideLength;
        public abstract double CalculateArea();
        public abstract void Draw();
    }

    // Circle class
    public class Circle : Shape
    {
        private double radius;

        public Circle(double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle at ({x}, {y}) with radius {radius}");
        }
    }

    // Rectangle class
    public class Rectangle : Shape
    {
        public double length, width;

        public Rectangle(double x, double y, double length, double width)
        {
            this.x = x;
            this.y = y;
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle at ({x}, {y}) with length {length} and width {width}");
        }
    }

    // Square class
    public class Square : Shape
    {
        public double sideLength;

        public Square(double x, double y, double sideLength)
        {
            this.x = x;
            this.y = y;
            this.sideLength = sideLength;
        }

        public override double CalculateArea()
        {
            return Math.Pow(sideLength, 2);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a square at ({x}, {y}) with side length {sideLength}");
        }
    }

    // Canvas class for drawing shapes
    public class Canvas
    {
        private List<Shape> shapes = new List<Shape>();

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }

        public void DrawShapes()
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
        public void calcShapes()
        {
            foreach (var shape in shapes)
            {
                shape.CalculateArea();
            }
        }
    }

}
