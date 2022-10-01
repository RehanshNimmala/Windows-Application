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
    public partial class SingletonContainerForm : Form
    {
        public SingletonContainerForm()
        {
            InitializeComponent();
        }//ctor

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }//about

      

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SingletonFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Create an instance using static method
            SingletonForm singletonInstForm = SingletonForm.SingletonFormInstance();
            //make it a child
            singletonInstForm.MdiParent = this;
            singletonInstForm.Show();

        }
    }
}
