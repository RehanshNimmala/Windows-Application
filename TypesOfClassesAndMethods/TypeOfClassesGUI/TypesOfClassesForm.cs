using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeOfClassesGUI
{
    public partial class TypesOfClassesForm : Form
    {
        public TypesOfClassesForm()
        {
            InitializeComponent();
        }

        private void baseClassButton_Click(object sender, EventArgs e)
        {
            MyBaseClass myBaseClass = new MyBaseClass("Krushna Chinthada");
            definitionLabel.Text=myBaseClass.ToString();
            resultLabel.Text=myBaseClass.ShowDetails;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            definitionLabel.Text = "";
            resultLabel.Text = "";
            definitionLabel.Text = "Objective of this lab is to create all the classes";
            resultLabel.Text = $"Name of this object is :{this.GetType().Name}\r\nName of the namespace is :{this.GetType().Namespace}\r\nFull name is(from ToString() method):{this.GetType().ToString()}";
        }

        private void staticClassButton_Click(object sender, EventArgs e)
        {
            definitionLabel.Text=MyStaticClass.ToString();
            resultLabel.Text = MyStaticClass.StaticShowDetails();
        }

        private void derivedClassButton_Click(object sender, EventArgs e)
        {
            MyDerivedClass myDerivedClass = new MyDerivedClass("Krushna Ch");
            definitionLabel.Text=myDerivedClass.ToString();
            resultLabel.Text= myDerivedClass.ShowDetails;


        }

        private void sealedClassButton_Click(object sender, EventArgs e)
        {
            MySealedClass mySealedClass = new MySealedClass();
            definitionLabel.Text=mySealedClass.ToString();
            resultLabel.Text = mySealedClass.ShowDetails();
        }

        private void abstractImpleButton_Click(object sender, EventArgs e)
        {
            ImplementAbstractClass myImplementAbstractClass = new ImplementAbstractClass();
            definitionLabel.Text=myImplementAbstractClass.ToString();
            resultLabel.Text=myImplementAbstractClass.AbstractShowDetails();
        }
    }
}
