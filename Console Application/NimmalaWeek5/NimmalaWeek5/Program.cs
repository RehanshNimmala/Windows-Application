using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NimmalaWeek5
{
    //Created by Nimmala
    //4444444444444444444
     class Program
    {
        static void Main(string[] args)
        {
            //Declaring a list with objects of type either circle,Square or shape.
            var myShapes = new List<Shape>
            {
                new Circle(1,1),// Upcasting a circle into shape because circle is derived from shape
                new Square(2),
                new Shape(3,3),
            };
            //Loop through each of the elements in the list to test out down-casting
            foreach(var shape in myShapes)
            {
                //display what type the element in the iteration is:
                Console.WriteLine("This is a"+shape.GetType().Name);
                shape.Draw();//calling the Draw method of shape class.
                //Downcasting
                //You declared a list of type shape.but put deribved class shapes(circle and square) in the shapes
                //list because they alsobelong to the same base class.
                //test whether we can downcast the types:
                var circle =shape as Circle;
                // You can use as operator to perform certain types of conversions
                // between compatible reference types or nullable types

                if (circle != null)
                {
                    Console.WriteLine("Inside If block.Downcasted shape to Circle.Should be able to use the Circle class methods now.Calling Circle's' Fill Method:\n");
                        circle.FillColor("APPLE GREEN");
                }
                else if (shape is Square)
                {
                    Console.WriteLine("Inside the elseIf block--shape is square.About to downcast shape to a square, so we can use the Draw method from the square class.\n");
                    ((Square)shape).Draw();
                }
                else
                {
                    Console.WriteLine("Inside the Else block, shape is neither a circle nor a square.cannot be down casted to either classes.\n");
                }
                Console.WriteLine("\n");
                
            }// End of each
            Console.ReadLine();
        }
    }
}
