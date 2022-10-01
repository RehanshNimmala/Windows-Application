using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonPractise
{
    //Created by Naveen
    //111111111111111
    public partial class SingletonForm : Form
    {
        private static SingletonForm instance;
        private SingletonForm()
        {
            InitializeComponent();
        }//ctor
        internal static SingletonForm SingletonFormInstance()
        {
            //This method returns an instance of singletonForm, only of instance is null.
            if(instance == null)
                instance= new SingletonForm();
            return instance;
        }

        private void SingletonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // when the form closes,make the instance null.so the form loads again when called for the second time
            instance=null;
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text=$"Hello{nameTextBox.Text}";
        }
    }
}
