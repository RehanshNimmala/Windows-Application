using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NimmalaWeek7
{
    public partial class SingletonForm : Form
    {
        private static SingletonForm SingletonInstance;
        private SingletonForm()
        {
            InitializeComponent();
        }// end of ctor

      internal static SingletonForm singletonFormInstance()
        {
            // this method returns an instance of singletonform, only if instance is null
            if(SingletonInstance == null)
                SingletonInstance = new SingletonForm();
            return SingletonInstance;
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            helloLabel.Text = $"Hello{nameTextBox.Text}";
        }

        private void SingletonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SingletonInstance=null;
        }
    }
}
