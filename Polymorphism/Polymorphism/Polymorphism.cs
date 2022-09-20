using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymorphism
{
    public partial class Polymorphism : Form
    {
        public Polymorphism()
        {
            InitializeComponent();
        }

        private void shapeButton_Click(object sender, EventArgs e)
        {
            ClassShape shape = new ClassShape(20, 30);
            resultTextBox.Text = shape.Draw();
        }//shapeButton

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Exit button

        private void circleButton_Click(object sender, EventArgs e)
        {
            ClassCircle circle = new ClassCircle(45, 60);
            resultTextBox.Text = circle.Draw();
            resultTextBox.Text +=$"Circle Class Draw method is inherited from ShapeClass.{Environment.NewLine}";
            resultTextBox.Text += circle.FillColor("Red");
        }//Circle button

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            //Instantiate both rectangle and square and supply appropriate arguments for overloaded ctor:
            ClassRectangle rectangle = new ClassRectangle(20, 25);
            ClassRectangle square = new ClassRectangle(25);
            resultTextBox .Text =rectangle.Draw();
            resultTextBox.Text += Environment.NewLine;
            resultTextBox.Text+=square.Draw();
        }//Rectangle button

        private void upCastingButton_Click(object sender, EventArgs e)
        {
            ClassShape circleShape = new ClassCircle(33, 34);
            //Upcasting converts an object of a specialized type to a more general type
            string message = $@"Drawing a CircleShape from upcasting circle as a shape object:
                {circleShape.Draw()}.{Environment.NewLine}.
            Note that the upcast circleshape object does not have access to the circle.FillColor()method because it is upcast";
            resultTextBox.Text = message;          
        }//Upcasting by Instantiation

        private void upCastingByAsmtButton_Click(object sender, EventArgs e)
        {
            ClassShape shape = new ClassShape(10, 15);
            ClassRectangle rectangle=new ClassRectangle(30, 45);
            ClassCircle circle = new ClassCircle(60, 75);

            string message = "";
            message +=$"Drawing shape:{shape.Draw()}";
            message +=$"{Environment.NewLine}Drawing Rectangle:{rectangle.Draw()}";
            message += $"{Environment.NewLine + Environment.NewLine}" +
                $"upcasting:By assignment:rectangle as a shape(shape=rectangle;).{Environment.NewLine}";
            shape = rectangle;//Assignment
            message+=$"Drawing shape:{shape.Draw()}";
            resultTextBox .Text = message;


        }

        private void downCastingButton_Click(object sender, EventArgs e)
        {
            string message = $"try this code:{Environment.NewLine}" +
                $"ClassCircle downshape=(ClassCircle)new ClassShape(35,37);{Environment.NewLine}" +
                $"string message=downShape.FillColor(\"Blue\");{Environment.NewLine}" +
                $@"That will be ok & IDE will not throw an error.But it will be caught as an error in run time(Inalid cast Error)
                DownCasting is not type-safe!{Environment.NewLine}+{Environment.NewLine}" +
                $"Any other form of instance Downcasting such as this one below will also throw runtime error:{Environment.NewLine}" +
                $"Rectangle=(ClassRectangle)shape;{Environment.NewLine}" +
                $" message+= rectangle.Draw();{Environment.NewLine}" +
                $@"//Instantiating two objects:
                {Environment.NewLine}ClassShape=new ClassShape(66,67);
                 {Environment.NewLine}ClassRectangle rectangle=new ClassRectangle(44,45);" +
                 $@"{Environment.NewLine}Moral :Do NOT do Down Casting.
                    It will throw errors in runtime even if IDE does not scream about it
                    But C# supports DownCasting!! See other code";
            resultTextBox.Text = message;

        }

        private void okDownCastingButton_Click(object sender, EventArgs e)
        {
            ClassShape shapeR = new ClassRectangle(34, 45);
            ClassRectangle rectangle = new ClassRectangle(11, 22);
            if(shapeR is ClassRectangle)
            {
                resultTextBox.Text = $@"{shapeR.Draw()}+{Environment.NewLine + Environment.NewLine}.
                DownCasting works if shapeR isalso of the type ClassRectangle!{Environment.NewLine}+
                That worked because: You initialized the shape object type, with the rectangle ctor which makes
                the shape object a Rectangle!
                {Environment.NewLine} ClassShape shapeR=new ClassRectangle(34,35);";

            }
        }
    }// form class
}//namespace
