using _210042111_lab04_grpB;

namespace grbb_test
{

    [TestClass]
    public class CanvasTests
    {
        [TestMethod]
        public void AddShape_AddCircle_ShouldAddToShapesList()
        {
            // Arrange
            var canvas = new Canvas();
            var circle = new Circle(0, 0, 5);

            // Act
            canvas.AddShape(circle);

            // Assert
           // Assert.AreEqual(1, canvas.calcShapes());
            //gvAssert.AreEqual(circle, canvas.Shapes[0]);
        }

        [TestMethod]
        public void DrawShapes_ShouldPrintShapes()
        {
            // Arrange
            var canvas = new Canvas();
            var circle = new Circle(0, 0, 5);
            var rectangle = new Rectangle(0, 0, 4, 6);
            canvas.AddShape(circle);
            canvas.AddShape(rectangle);

            // Act (Redirect Console Output to Test Output)
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                canvas.DrawShapes();
                var expectedOutput = "Drawing a circle at (0, 0) with radius 5" + Environment.NewLine +
                                     "Drawing a rectangle at (0, 0) with length 4 and width 6" + Environment.NewLine;

                // Assert
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }

        [TestMethod]
        public void CalculateArea_ShouldCalculateAreaForShapes()
        {
            // Arrange
            var canvas = new Canvas();
            var circle = new Circle(0, 0, 5);
            var rectangle = new Rectangle(0, 0, 4, 6);
            canvas.AddShape(circle);
            canvas.AddShape(rectangle);

            // Act
            canvas.calcShapes();

            // Assert (You should enhance the test based on your requirements)
            Assert.AreEqual(78.54, circle.CalculateArea(), 0.01); // Using an approximate value with a tolerance
            Assert.AreEqual(24.0, rectangle.CalculateArea());
        }
    }
    }