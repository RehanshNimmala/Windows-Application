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
    public partial class SingletonContainerForm : Form
    {
        public SingletonContainerForm()
        {
            InitializeComponent();
        }

     

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void showSingletonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingletonForm singletonInstForm = SingletonForm.singletonFormInstance();
            singletonInstForm.MdiParent = this;
            singletonInstForm.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
