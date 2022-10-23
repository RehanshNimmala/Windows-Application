using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceHW
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getting the collection of rectangles defined in rectangle class.
            IIndex<Rectangle> rectangles = RectangleCollection.getRectangles();

            IIndex<Shape> shapes = rectangles;//IIndex is a covariant interface.
            //Covariance enables you to use a more derived type than originally specified.Instead of using shapes, IIndex allows use of a more derived rectangle type.

            for (int i = 0; i < shapes.count; i++)
            {
                Console.WriteLine($"{shapes[i]} {Environment.NewLine}");//shapes[i] is in effect calling the overridden Tostring() method.
            }// end for 
            Console.WriteLine();
            Console.ReadKey();
            IDisplay<Shape> shapeDisplay = new ShapeDisplay();//IDisplay is a contravariant interface
            //Contravariant type paramerters are defined with in parameter and can only be used as method parameters.

            IDisplay<Rectangle> rectangleDisplay = shapeDisplay;
            rectangleDisplay.Show(rectangles[0]);
            Console.WriteLine();
            Console.ReadKey();



        }
    }
}
