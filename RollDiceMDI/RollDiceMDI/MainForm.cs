using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RollDiceMDI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InstructionsForm instructionsForm = new InstructionsForm();
            instructionsForm.MdiParent = this;
            instructionsForm.Show();
        }//End Instructions

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrapsForm crapsForm = new CrapsForm();
            crapsForm.MdiParent = this;
            crapsForm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.MdiParent = this; 
            aboutBox1.Show();
        }//about
    }
}
