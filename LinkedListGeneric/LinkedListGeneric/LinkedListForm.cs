using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListGeneric
{
    public partial class LinkedListForm : Form
    {
        public LinkedListForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void integerButton_Click(object sender, EventArgs e)
        {
            string result = "";
            // Instantiate the linked class with integer nodes
            var integerLinkedList = new LinkedListClass<int>();
            //add one node value at time by calling addList method
            integerLinkedList.AddLast(111);
            integerLinkedList.AddLast(222);
            integerLinkedList.AddLast(3333);
            // iterate through the linked list and display the values

            foreach (int i in integerLinkedList)
            {
                result += i.ToString() + Environment.NewLine;
            }
            resultLabel.Text = result;
        }

        private void boolButton_Click(object sender, EventArgs e)
        {
            string result = "";
            // Instantiate the linked class for boolean
            var boolLinkedList = new LinkedListClass<bool>();
            //add one node value at time by calling addList method
            boolLinkedList.AddLast(true);
            boolLinkedList.AddLast(false);
            boolLinkedList.AddLast(true);
            // iterate through the linked list and display the values

            foreach (bool b in boolLinkedList)
            {
                result += b.ToString() + Environment.NewLine;
            }
            resultLabel.Text = result;
        }

        private void stringButton_Click(object sender, EventArgs e)
        {
            string result = "";
            // Instantiate the linked class for string 
            var stringLinkedList = new LinkedListClass<string>();
            //add one node value at time by calling addList method
            stringLinkedList.AddLast("First-No previous.There may be next when nodes were added");
            stringLinkedList.AddLast("Second:One previous node exists,last node now, but there may be more when nodes were added");
            stringLinkedList.AddLast("Last node:Only previous nodes exists, But no next node");
            // iterate through the linked list and display the values

            foreach (string s in stringLinkedList)
            {
                result += s + Environment.NewLine;
            }
            resultLabel.Text = result;
        }

        private void mixedTypeButton_Click(object sender, EventArgs e)
        {
            string result = "";
            // Instantiate the linked class for boolean
            var mixedLinkedList = new LinkedListClass<object>();
            //add one node value at time by calling addList method
            mixedLinkedList.AddLast(1111);
            mixedLinkedList.AddLast(false);
            mixedLinkedList.AddLast("String");
            // iterate through the linked list and display the values

            foreach (var v in mixedLinkedList)
            {
                result += $"{v.ToString()}:Date type is:{v.GetType().Name}  {Environment.NewLine}";
            }
            resultLabel.Text = result;
        }
    }
}
